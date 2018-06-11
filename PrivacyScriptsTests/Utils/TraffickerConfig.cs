using System.Collections.Generic;
using System.Configuration;

namespace PrivacyScriptsTests.Utils
{
	public class TraffickerConfig : ConfigBase
	{
		private static TraffickerConfig _default;

		public static TraffickerConfig Default
		{
			get
			{
				if (_default == null)
				{
					var domain = ConfigurationManager.AppSettings["domain"];

					_default = new TraffickerConfig()
					{
						Protocol = "https:",
						CDN = "dev.betrad.com",
						CompanyId = 242,
						Domain = domain
					};
				}

				return _default;
			}
		}

		public string Protocol { get; set; }
		public string CDN { get; set; }
		public int CompanyId { get; set; }
		public string Domain { get; set; }

		public TraffickerConfig()
		{

		}

		public override Dictionary<string, string> ToDictionary()
		{
			var parameters = new Dictionary<string, string>();

			parameters.Add("{protocol}", Protocol);
			parameters.Add("{cdn}", CDN);
			parameters.Add("{companyId}", CompanyId.ToString());
			parameters.Add("{domain}", Domain);

			return parameters;
		}
	}
}
