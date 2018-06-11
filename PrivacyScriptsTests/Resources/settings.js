(function () {
	var a = {};
	a["tests.privacyscripts.com|1"] = {
		id: 1,
		themeId: {themeId},
		consentDisplayType: {consentDisplayType},
		division: {division},
		includeSubdomains: {includeSubdomains},
		dataRightsFormEmails: {
			1: "test.privacy.1@crownpeak.com",
			2: "test.privacy.2@crownpeak.com",
			3: "test.privacy.3@crownpeak.com",
		},
		rightsLinks: {
			1: "//somesite.com"
		},
		privacyLinks: {},
		countries: {
			1: {
				consentRequired: 1,
				consentid: 2,
				accessid: 2,
				duration: 13,
				consentactions: "",
				l2enabled: 1,
				gdprEnabled: 1,
				dataRightsType: 1,
				rightslinkId: 0,
				dataRightsFormEmailId: 1,
				privacyLinkId: 0,
				vendor: 1
			}
		},
		defaultCountry: 1,
		translations: {
			en: { "en-us": 3, "en-gb": 2 }
		},
		defaultTranslation: { id: 3, code: "en-us" },
		vendors: {vendors}
	};

	if (!window.evidon) window.evidon = {}

	if (window.evidon.notice) {
		window.evidon.notice.loadSettings(a)
	} else {
		window.evidon.settings = a
	}
}
)();
