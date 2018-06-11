using System.Collections.Generic;

namespace PrivacyScriptsTests.Utils
{
	public class ThemesConfig : ConfigBase
	{
		private static ThemesConfig _default;

		public static ThemesConfig Default
		{
			get
			{
				if (_default == null)
				{
					_default = new ThemesConfig();
				}

				return _default;
			}
		}

		public ThemesConfig()
		{
		}

		public override Dictionary<string, string> ToDictionary()
		{
			var parameters = new Dictionary<string, string>();

			return parameters;
		}
	}
}
