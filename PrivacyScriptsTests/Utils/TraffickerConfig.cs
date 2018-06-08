using System.Collections.Generic;
using System.Configuration;

namespace PrivacyScriptsTests
{
	public class TraffickerConfig
	{
		private static TraffickerConfig _default;

		public static TraffickerConfig Default
		{
			get
			{
				if (_default == null)
				{
					var protocol = ConfigurationManager.AppSettings["protocol"];
					var cdn = ConfigurationManager.AppSettings["cdn"];
					var companyId = int.Parse(ConfigurationManager.AppSettings["companyId"]);
					var domain = ConfigurationManager.AppSettings["domain"];

					_default = new TraffickerConfig()
					{
						Protocol = protocol,
						CDN = cdn,
						CompanyId = companyId,
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

		public int ConsentType { get; set; }

		public TraffickerConfig()
		{

		}

		public Dictionary<string, string> ToDictionary()
		{
			var parameters = new Dictionary<string, string>();

			parameters.Add("{cdn}", CDN);
			parameters.Add("{protocol}", Protocol);
			parameters.Add("{companyId}", CompanyId.ToString());
			parameters.Add("{domain}", Domain);

			return parameters;
		}
	}
}
