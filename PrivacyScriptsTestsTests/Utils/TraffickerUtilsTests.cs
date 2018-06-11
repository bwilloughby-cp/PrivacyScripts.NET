using NUnit.Framework;
using PrivacyScriptsTests.Utils;
using System;

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

			Assert.AreEqual(3, TraffickerUtils._files.Count);

			TraffickerUtils.CleanUpFiles();

			Assert.AreEqual(0, TraffickerUtils._files.Count);
		}

		[Test]
		public void TestCreateHTMLNoCleanup()
		{
			var htmlPath = TraffickerUtils.CreateTraffickerHTML();
			Console.WriteLine(htmlPath.LocalPath);

			TraffickerUtils._files.Clear();
		}
	}
}
