(function () {
	var a = {};
	a["brandon.willoughby.com/us|41"] = {
		id: 41,
		themeId: 23,
		consentDisplayType: 1,
		division: "Ghostery",
		includeSubdomains: 2,
		dataRightsFormEmails: {
			1: "brandon.willoughby@crownpeak.com"
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
			},
			9: {
				consentRequired: 1,
				consentid: 2,
				accessid: 2,
				duration: 13,
				consentactions: "ps",
				l2enabled: 1,
				gdprEnabled: 0,
				dataRightsType: 1,
				rightslinkId: 1,
				dataRightsFormEmailId: 1,
				privacyLinkId: 0,
				vendor: 1
			}
		},
		defaultCountry: 1,
		translations: {
			en: {
				"en-us": 3,
				"en-gb": 2
			},
			ar: {
				ar: 33
			},
			fr: {
				fr: 4
			},
			he: {
				he: 34
			},
			no: {
				no: 9
			},
			es: {
				"es-us": 17
			}
		},
		defaultTranslation: {
			id: 3,
			code: "en-us"
		},
		vendors: {
			1: [38, 391, 710, 713, 762, 1051, 1238, 1275, 1365, 1386, 1652, 1730, 1854, 2054, 2101, 2531, 2635, 2685, 3037, 3489, 3610, 4200, 4485]
		}
	};
	a["brandon.willoughby.com/en-uk|63"] = {
		id: 63,
		themeId: 1,
		consentDisplayType: 1,
		division: "Ghostery",
		includeSubdomains: 2,
		dataRightsFormEmails: {},
		rightsLinks: {},
		privacyLinks: {},
		countries: {
			1: {
				consentRequired: 0,
				consentid: 2,
				accessid: 2,
				duration: 6,
				consentactions: "",
				l2enabled: 0,
				gdprEnabled: 0,
				dataRightsType: 0,
				rightslinkId: 0,
				dataRightsFormEmailId: 0,
				privacyLinkId: 0,
				vendor: 1
			},
			9: {
				consentRequired: 0,
				consentid: 2,
				accessid: 2,
				duration: 6,
				consentactions: "",
				l2enabled: 0,
				gdprEnabled: 0,
				dataRightsType: 0,
				rightslinkId: 0,
				dataRightsFormEmailId: 0,
				privacyLinkId: 0,
				vendor: 1
			}
		},
		defaultCountry: 1,
		translations: {
			en: {
				"en-us": 3,
				"en-ca": 45,
				"en-gb": 2
			},
			ar: {
				ar: 33,
				"ar-eg": 52
			},
			hy: {
				hy: 46
			},
			de: {
				"de-at": 40,
				de: 5,
				"de-ch": 14
			},
			bg: {
				bg: 23
			},
			fr: {
				"fr-ca": 35,
				fr: 4,
				"fr-ch": 15
			},
			ca: {
				ca: 41
			},
			hr: {
				hr: 42
			},
			cs: {
				cs: 21
			},
			da: {
				da: 8
			},
			nl: {
				nl: 1,
				"nl-be": 16
			},
			et: {
				et: 25
			},
			fi: {
				fi: 18
			},
			ka: {
				ka: 53
			},
			el: {
				el: 22
			},
			he: {
				he: 34
			},
			hu: {
				hu: 13
			},
			is: {
				is: 30
			},
			id: {
				id: 47
			},
			it: {
				it: 6
			},
			ja: {
				ja: 39
			},
			ko: {
				ko: 38
			},
			lv: {
				lv: 26
			},
			lt: {
				lt: 27
			},
			mk: {
				mk: 43
			},
			ms: {
				ms: 51
			},
			mt: {
				mt: 29
			},
			no: {
				no: 9
			},
			pl: {
				pl: 10
			},
			pt: {
				pt: 19,
				"pt-br": 20
			},
			ro: {
				ro: 24
			},
			ru: {
				ru: 31
			},
			rs: {
				rs: 44
			},
			zh: {
				"zh-cn": 36,
				"zh-tw": 37
			},
			sk: {
				sk: 12
			},
			sl: {
				sl: 28
			},
			es: {
				es: 7,
				"es-us": 17
			},
			sv: {
				sv: 11
			},
			ph: {
				ph: 48
			},
			th: {
				th: 49
			},
			tr: {
				tr: 32
			},
			uk: {
				uk: 50
			},
			vi: {
				vi: 54
			}
		},
		defaultTranslation: {
			id: 3,
			code: "en-us"
		},
		vendors: {
			1: []
		}
	};
	if (!window.evidon) {
		window.evidon = {}
	}
	if (window.evidon.notice) {
		window.evidon.notice.loadSettings(a)
	} else {
		window.evidon.settings = a
	}
}
)();
