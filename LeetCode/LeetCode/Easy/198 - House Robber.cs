using System;

// https://leetcode.com/problems/house-robber/
public partial class Solution
{
    // The order is: prev2, prev1, num
    public int Rob(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        int prev1 = 0;
        int prev2 = 0;
        foreach (int num in nums)
        {
            int tmp = prev1;
            prev1 = Math.Max(prev2 + num, prev1);
            prev2 = tmp;
        }

        return prev1;
    }
}
