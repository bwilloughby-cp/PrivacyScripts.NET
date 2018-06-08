using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Collections;

namespace PrivacyScriptsTests
{
	public class BrowserFixtureData
	{
		public static IEnumerable FixtureParams
		{
			get
			{
				yield return new TestFixtureData(typeof(FirefoxDriver));
				yield return new TestFixtureData(typeof(ChromeDriver));
			}
		}
	}
}
