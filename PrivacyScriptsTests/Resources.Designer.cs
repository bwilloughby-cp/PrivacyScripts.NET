﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrivacyScriptsTests {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PrivacyScriptsTests.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (function () {
        ///	var a = {};
        ///	a[&quot;brandon.willoughby.com/us|41&quot;] = {
        ///		id: 41,
        ///		themeId: 23,
        ///		consentDisplayType: 1,
        ///		division: &quot;Ghostery&quot;,
        ///		includeSubdomains: 2,
        ///		dataRightsFormEmails: {
        ///			1: &quot;brandon.willoughby@crownpeak.com&quot;
        ///		},
        ///		rightsLinks: {
        ///			1: &quot;//somesite.com&quot;
        ///		},
        ///		privacyLinks: {},
        ///		countries: {
        ///			1: {
        ///				consentRequired: 1,
        ///				consentid: 2,
        ///				accessid: 2,
        ///				duration: 13,
        ///				consentactions: &quot;&quot;,
        ///				l2enabled: 1,
        ///				gdprEnabled: 1,
        ///				dataRightsType: 1,
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string settingsJS {
            get {
                return ResourceManager.GetString("settingsJS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;
        ///
        ///&lt;head&gt;
        ///	&lt;meta charset=&quot;UTF-8&quot;&gt;
        ///	&lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1.0&quot;&gt;
        ///	&lt;title&gt;SiteNotice 3 Tester&lt;/title&gt;
        ///
        ///	&lt;!--&lt;link rel=&quot;stylesheet&quot; href=&quot;../normalize.css&quot;&gt;--&gt;
        ///
        ///	&lt;div class=&apos;evidon-notice-link&apos;&gt;&lt;/div&gt;
        ///	&lt;script type=&quot;text/javascript&quot;&gt;
        ///		(function (id) {
        ///			function append(scriptid, url, async) {
        ///				var d = document, sn = &apos;script&apos;, f = d.getElementsByTagName(sn)[0];
        ///				if (!f) f = d.head;
        ///				var s = d.createElement(sn);
        ///				s.async = true;
        ///				s. [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string sitenotice3 {
            get {
                return ResourceManager.GetString("sitenotice3", resourceCulture);
            }
        }
    }
}