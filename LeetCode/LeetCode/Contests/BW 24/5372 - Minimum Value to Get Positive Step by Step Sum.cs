// 
using System;

public partial class Solution
{
    public int MinStartValue(int[] nums)
    {
        int sum = 0;
        int min = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            min = Math.Min(min, sum);
        }

        if (min >= 1)
            return 1;
        return Math.Abs(min) + 1;
    }
}