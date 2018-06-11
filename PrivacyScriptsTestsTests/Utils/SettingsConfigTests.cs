using NUnit.Framework;
using PrivacyScriptsTests.Utils;
using System.Linq;

namespace PrivacyScriptsTests.Tests.Utils
{
	public class SettingsConfigTests
	{
		private SettingsConfig _settings;

		[SetUp]
		public void SetUp()
		{
			_settings = SettingsConfig.Default;
		}

		[TearDown]
		public void TearDown()
		{
			_settings = null;
		}

		[Test]
		public void TestCreateParameters()
		{
			var parameters = _settings.ToDictionary();

			Assert.IsTrue(parameters.Keys.Contains("{consentDisplayType}"));

			var expected = ((int)Enums.ConsentDisplayType.BANNER).ToString();
			Assert.AreEqual(expected, parameters["{consentDisplayType}"]);
		}
	}
}
