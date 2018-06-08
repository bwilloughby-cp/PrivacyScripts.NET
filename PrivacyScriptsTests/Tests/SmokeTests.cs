using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PrivacyScriptsTests.Utils;
using System;
using System.IO;
using System.Threading;

namespace PrivacyScriptsTests.Tests
{
	[TestFixtureSource(typeof(BrowserFixtureData), "FixtureParams")]
	public class SmokeTests
	{
		private Type _driverType;
		private DriverManager driverManager;

		public SmokeTests(Type driverType)
		{
			this._driverType = driverType;

			driverManager = new DriverManager(this._driverType);
		}

		private Uri htmlPath;

		[SetUp]
		public void SetUp()
		{
			htmlPath = TraffickerUtils.CreateTraffickerHTML();
			Assert.True(File.Exists(htmlPath.LocalPath));

			this.driverManager.Start();
		}

		[TearDown]
		public void TearDown()
		{
			driverManager.Dispose();

			TraffickerUtils.CleanUpFiles();
		}

		[Test]
		public void TestHtmlIsReadable()
		{
			var driver = driverManager.Driver;

			driver.Manage().Cookies.DeleteAllCookies();
			driver.Navigate().GoToUrl(htmlPath);

			var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

			wait.Until(condition =>
			{
				try
				{
					var ele = driverManager.Driver.FindElement(By.Id(EvidonConstants.Banner.BANNER_ID));
					return ele.Displayed;
				}
				catch (StaleElementReferenceException)
				{
					return false;
				}
				catch (NoSuchElementException)
				{
					return false;
				}
			});

			var banner = driver.FindElement(By.Id(EvidonConstants.Banner.BANNER_ID));
			Assert.NotNull(banner);
			Assert.AreNotEqual("none", banner.GetCssValue("display"));

			IWebElement btnAccept = driver.FindElement(By.Id(EvidonConstants.Banner.ACCEPT_BUTTON_ID));
			Assert.NotNull(btnAccept);
			btnAccept.Click();

			// banner should now be missing from the DOM
			Assert.Throws<NoSuchElementException>(() => driver.FindElement(By.Id(EvidonConstants.Banner.BANNER_ID)));
		}

		private bool ElementExists(string id)
		{
			try
			{
				var ele = driverManager.Driver.FindElement(By.Id(id));
				return ele.Displayed;
			}
			catch (StaleElementReferenceException)
			{
				return false;
			}
			catch (NoSuchElementException)
			{
				return false;
			}
		}
	}
}
