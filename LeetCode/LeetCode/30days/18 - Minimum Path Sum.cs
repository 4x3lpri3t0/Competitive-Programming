// https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/530/week-3/3303/
using System;

public partial class Solution
{
    public int MinPathSum(int[][] grid)
    {
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (i == 0 && j == 0)
                    continue;
                else if (i == 0) // 1st row, take left
                    grid[i][j] += grid[i][j - 1];
                else if (j == 0) // 1st col, take up
                    grid[i][j] += grid[i - 1][j];
                else
                    grid[i][j] += Math.Min(grid[i - 1][j], grid[i][j - 1]);
            }
        }

        return grid[grid.Length - 1][grid[0].Length - 1];
    }
}