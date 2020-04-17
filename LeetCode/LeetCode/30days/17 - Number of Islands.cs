// https://leetcode.com/explore/challenge/card/30-day-leetcoding-challenge/530/week-3/3302/
public partial class Solution
{
	private char[][] grid;
	private int rowCount;
	private int colCount;

	public int NumIslands(char[][] grid)
	{
		if (grid == null || grid.Length == 0)
			return 0;

		this.grid = grid;
		this.rowCount = grid.Length;
		this.colCount = grid[0].Length;

		var result = 0;

		for (var i = 0; i < rowCount; i++)
		{
			for (var j = 0; j < colCount; j++)
			{
				if (grid[i][j] == '1')
				{
					result++;
					DFS(i, j);
				}
			}
		}

		return result;
	}

	private void DFS(int r, int c)
	{
		if (r < 0 || r >= rowCount || c < 0 || c >= colCount || grid[r][c] == '0')
			return;

		grid[r][c] = '0';

		DFS(r + 1, c);
		DFS(r, c + 1);
		DFS(r - 1, c);
		DFS(r, c - 1);
	}
}