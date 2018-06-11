using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PrivacyScriptsTests.Utils
{
	public class TraffickerUtils
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
			var traffickerConfig = TraffickerConfig.Default;
			var settings = SettingsConfig.Default;
			var themes = ThemesConfig.Default;

			return CreateTraffickerHTML(traffickerConfig, settings, themes);
		}

		public static Uri CreateTraffickerHTML(TraffickerConfig traffickerConfig, SettingsConfig settingsConfig, ThemesConfig themeConfig)
		{
			var settingsJS = SetupJSFile(Resources.settingsJS, settingsConfig);
			var themeJS = SetupJSFile(Resources.themesJS, themeConfig);

			var parameters = traffickerConfig.ToDictionary();
			parameters.Add("{settingsJSPath}", settingsJS);
			parameters.Add("{themesJSPath}", themeJS);

			var content = Interpolate(Resources.sitenotice3, parameters);
			var traffickerFile = CreateTempFile(content, ".html");

			return new Uri(traffickerFile);
		}

		private static string SetupJSFile(string body, ConfigBase config)
		{
			var content = Interpolate(body, config.ToDictionary());
			var file = CreateTempFile(content, ".js");
			return Path.GetFileName(file);
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
