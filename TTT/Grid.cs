using System;
namespace TTT
{
	public class Grid
	{
		public Grid()
		{
			string[] gridvalues = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

			Console.WriteLine("\nWhere does this output appear?\n");
			Console.WriteLine(gridvalues);

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
