// https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/529/week-2/3298/
// https://leetcode.com/problems/contiguous-array/solution/
// https://www.youtube.com/watch?v=nSEO5zOwP7g
using System;
using System.Collections.Generic;

public partial class Solution
{
	public int FindMaxLength(int[] nums)
	{
		var counts = new Dictionary<int, int>();
		counts.Add(0, -1);

		int maxLength = 0;
		int count = 0;
		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] == 0)
				count += -1;
			else
				count += 1;

			if (counts.ContainsKey(count))
				maxLength = Math.Max(maxLength, i - counts[count]);
			else
				counts.Add(count, i);
		}

		return maxLength;
	}
}