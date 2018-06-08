using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivacyScriptsTests
{
	public class EvidonConstants
	{
		public class Cookie
		{
			public static readonly string CONSENT_NAME = "_evidon_consent_cookie";
		}

		public class Banner
		{
			public static readonly string BANNER_ID = "_evidon_banner";
			public static readonly string ACCEPT_BUTTON_ID = "_evidon-accept-button";
		}

		public class Barrier
		{
			public static readonly string BANNER_ID = "_evidon-banner";
			public static readonly string ACCEPT_BUTTON_ID = "_evidon-banner-acceptbutton";
		}
	}
}
