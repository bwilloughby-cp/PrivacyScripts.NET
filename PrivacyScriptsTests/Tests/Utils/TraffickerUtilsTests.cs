using NUnit.Framework;
using PrivacyScriptsTests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivacyScriptsTests.Tests.Utils
{
	public class TraffickerUtilsTests
	{
		[SetUp]
		public void SetUp()
		{
			TraffickerUtils.CleanUpFiles();
		}

		[TearDown]
		public void TearDown()
		{
			TraffickerUtils.CleanUpFiles();
		}

		[Test]
		public void TestCreateHTML()
		{
			var htmlPath = TraffickerUtils.CreateTraffickerHTML();
			Console.WriteLine(htmlPath.LocalPath);

			Assert.AreEqual(2, TraffickerUtils._files.Count);

			TraffickerUtils.CleanUpFiles();

			Assert.AreEqual(0, TraffickerUtils._files.Count);
		}
	}
}
