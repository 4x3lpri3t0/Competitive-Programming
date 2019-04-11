using System;

// https://leetcode.com/problems/min-cost-climbing-stairs/
public partial class Solution
{
    int[] cache;
    int[] cost;

    public int MinCostClimbingStairs(int[] c)
    {
        int i = c.Length - 3;
        while (i >= 0)
        {
            c[i] += Math.Min(c[i + 1], c[i + 2]);
            i--;
        }

        return Math.Min(c[0], c[1]);
    }
}
