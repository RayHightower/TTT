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

		[Test()]
		public void InitializetheGrid()
		{
			string[] ExpectedGrid = new string[] { "0", "1", "2", "3" };

			string[] ActualGrid = ExpectedGrid;
			// Grid ActualGrid = new Grid();

			for (int i = 1; i == 9; i++)
			{
				Assert.AreEqual(ExpectedGrid[i], ActualGrid[i]);
			}
		}

		[Test()]
		public void DrawtheGridCorrectly()
		{
			// Grid grid = new Grid();
			Assert.IsTrue(false);
		}
	}
}
