using System;
using System.Collections.Generic;

namespace PrivacyScriptsTests.Utils
{
	public class SettingsConfig : ConfigBase
	{
		private static SettingsConfig _default;

		public static SettingsConfig Default
		{
			get
			{
				if (_default == null)
				{
					_default = new SettingsConfig()
					{
						ThemeId = 1,
						ConsentDisplayType = (int)Enums.ConsentDisplayType.BANNER,
						Division = "Ghostery",
						IncludeSubdomains = 2,
						Vendors = new List<int>() { 1, 2, 3 }
					};
				}

				return _default;
			}
		}

		public int ThemeId { get; set; }
		public int ConsentDisplayType { get; set; }
		public string Division { get; set; }
		public int IncludeSubdomains { get; set; }
		public List<int> Vendors { get; set; }

		public SettingsConfig()
		{
			Vendors = new List<int>();
		}

		public override Dictionary<string, string> ToDictionary()
		{
			var parameters = new Dictionary<string, string>();

			parameters.Add("{themeId}", ThemeId.ToString());
			parameters.Add("{consentDisplayType}", ConsentDisplayType.ToString());
			parameters.Add("{division}", "\"" + Division + "\"");
			parameters.Add("{includeSubdomains}", IncludeSubdomains.ToString());

			var vendors = String.Join(", ", Vendors.ToArray());
			parameters.Add("{vendors}", $"{{ 1: [{vendors}] }},");

			return parameters;
		}
	}
}
