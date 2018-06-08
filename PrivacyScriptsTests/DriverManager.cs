using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;

namespace PrivacyScriptsTests
{
	public class DriverManager : IDisposable
	{
		private Type driverType;
		private int driverPID;

		public IWebDriver Driver { get; private set; }

		public DriverManager(Type driverType)
		{
			this.driverType = driverType;
		}

		public void Start()
		{
			var processName = "";
			if (driverType == typeof(FirefoxDriver))
			{
				processName = "geckodriver";
			}
			else if (driverType == typeof(ChromeDriver))
			{
				processName = "chromedriver";
			}
			if (String.IsNullOrEmpty(processName)) return;

			IEnumerable<int> pidsBefore = Process.GetProcessesByName(processName).Select(p => p.Id);
			Driver = (IWebDriver)Activator.CreateInstance(driverType);
			IEnumerable<int> pidsAfter = Process.GetProcessesByName(processName).Select(p => p.Id);

			driverPID = pidsAfter.Except(pidsBefore).First();
		}

		public void Dispose()
		{
			Driver.Close();
			Driver.Dispose();

			if (driverPID != -1)
			{
				_KillProcessAndChildren(driverPID);
			}
		}

		private void _KillProcessAndChildren(int pid)
		{
			try
			{
				ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" + pid);
				ManagementObjectCollection moc = searcher.Get();
				foreach (var managementObject in moc)
				{
					_KillProcessAndChildren(Convert.ToInt32(managementObject["ProcessID"]));
				}

				try
				{
					Process proc = Process.GetProcessById(pid);
					proc.Kill();
				}
				catch (Exception ex)
				{
					// Process already exited.
				}
			}
			catch (Exception ex)
			{
				// Swallow
			}
		}
	}
}
