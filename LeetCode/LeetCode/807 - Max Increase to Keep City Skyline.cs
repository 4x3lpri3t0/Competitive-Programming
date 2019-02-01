using System;

// https://leetcode.com/problems/max-increase-to-keep-city-skyline/
public partial class Solution
{
    public int MaxIncreaseKeepingSkyline(int[][] grid)
    {
        int[] maxX = new int[grid.Length];
        int[] maxY = new int[grid.Length];

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                maxX[i] = Math.Max(maxX[i], grid[i][j]);
                maxY[j] = Math.Max(maxY[j], grid[i][j]);
            }
        }

        int sum = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                sum += (Math.Min(maxX[i], maxY[j]) - grid[i][j]);
            }
        }

        return sum;
    }
}
