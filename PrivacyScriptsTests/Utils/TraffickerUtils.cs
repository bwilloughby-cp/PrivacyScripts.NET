using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PrivacyScriptsTests.Utils
{
	class TraffickerUtils
	{
		public static Queue<string> _files = new Queue<string>();

		public static void CleanUpFiles()
		{
			while (_files.Count > 0)
			{
				var fileName = _files.Dequeue();
				if (File.Exists(fileName))
					File.Delete(fileName);
			}
		}

		public static Uri CreateTraffickerHTML()
		{
			var config = TraffickerConfig.Default;

			return CreateTraffickerHTML(config);
		}

		public static Uri CreateTraffickerHTML(TraffickerConfig config)
		{
			var html = PrivacyScriptsTests.Resources.sitenotice3;
			return CreateTraffickerHTML(config, html);
		}

		public static Uri CreateTraffickerHTML(TraffickerConfig config, string html)
		{
			var settingsJS = PrivacyScriptsTests.Resources.settingsJS;
			return CreateTraffickerHTML(config, html, settingsJS);
		}

		public static Uri CreateTraffickerHTML(TraffickerConfig config, string html, string settingsJS)
		{
			var parameters = config.ToDictionary();

			//settingsJS = Interpolate(settingsJS, parameters);

			string tempJS = CreateTempFile(settingsJS, ".js");
			string baseJS = Path.GetFileName(tempJS);

			parameters.Add("{settingsJSPath}", baseJS);
			html = Interpolate(html, parameters);
			string tempHTML = CreateTempFile(html, ".html");

			return new Uri(tempHTML);
		}

		private static string Interpolate(string body, Dictionary<string, string> parameters)
		{
			return parameters.Aggregate(body, (current, parameter) => current.Replace(parameter.Key, parameter.Value));
		}

		private static string CreateTempFile(string body, string ext)
		{
			string tempFile = CreateTempFileName(ext);
			File.WriteAllText(tempFile, body);
			_files.Enqueue(tempFile);

			return tempFile;
		}

		private static string CreateTempFileName(string ext = ".txt")
		{
			return Path.Combine(new string[] { Path.GetTempPath(), Path.GetRandomFileName() + ext });
		}
	}
}
