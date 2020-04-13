using System;

// https://leetcode.com/problems/min-cost-climbing-stairs/
public partial class Solution
{
    public int MinCostClimbingStairs(int[] c)
    {
        for (int i = c.Length - 3; i >= 0; i--)
        {
            c[i] += Math.Min(c[i + 1], c[i + 2]);
        }

        return Math.Min(c[0], c[1]);
    }
}
