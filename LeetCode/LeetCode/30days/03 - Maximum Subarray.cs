// https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/528/week-1/3285/
using System;

public partial class Solution
{
	public int MaxSubArray(int[] nums)
	{
		int globalMax = nums[0];
		int currentSum = nums[0];

		for (int i = 1; i < nums.Length; i++)
		{
			currentSum = Math.Max(nums[i], currentSum + nums[i]);
			globalMax = Math.Max(globalMax, currentSum);
		}

		return globalMax;
	}
}