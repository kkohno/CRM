using System;
using NUnit.Framework;

namespace CRM_TEST
{
	[TestFixture]
	public class NUnitTest1
	{
		[Test]
		public void TestMethod1()
		{
			Assert.That(false, Is.False);
		}
	}
}