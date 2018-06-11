using NUnit.Framework;
using PrivacyScriptsTests.Utils;
using System.Linq;

namespace PrivacyScriptsTests.Tests.Utils
{
	public class ThemesConfigTests
	{
		private ThemesConfig _settings;

		[SetUp]
		public void SetUp()
		{
			_settings = ThemesConfig.Default;
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

			Assert.NotNull(parameters);
		}
	}
}
