using NUnit.Framework;
using System;
namespace TTT.Tests
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void MustPass()
		{
			int expected = 1;
			int actual = 1;
			Assert.AreEqual(expected, actual);
		}

		[Test()]
		public void WhenProjectStartedIsActive()
		{
			Project project = new Project();
			project.Start();
			Assert.IsTrue(project.IsActive);
		}
	}
}
