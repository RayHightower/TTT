using System;
namespace TTT
{
	public class Grid
	{
		public Grid()
		{
			char[] gridvalues = new char[10];

			LoadGrid(gridvalues);

		}

		static char[] LoadGrid(char[] grid)
		{
			for (int i = 1; i < 10; i++)
			{
				grid[i] = (char)(i + 48);
			}
			return grid;
		}

	}
}
