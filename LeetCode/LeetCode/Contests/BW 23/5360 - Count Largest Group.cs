// https://leetcode.com/contest/biweekly-contest-23/problems/count-largest-group/
using System;
using System.Collections.Generic;

public partial class Solution
{
	public int CountLargestGroup(int n)
	{
		var groupSizeMap = new Dictionary<int, int>();

		int maxGroup = 0;
		for (int i = 1; i <= n; i++)
		{
			int digitsSum = GetDigitsSum(i);
			if (!groupSizeMap.ContainsKey(digitsSum))
				groupSizeMap.Add(digitsSum, 0);

			groupSizeMap[digitsSum]++;
			maxGroup = Math.Max(groupSizeMap[digitsSum], maxGroup);
		}

		int largestCount = 0;
		foreach (var kv in groupSizeMap)
		{
			if (kv.Value == maxGroup)
				largestCount++;
		}

		return largestCount;
	}

	private int GetDigitsSum(int n)
	{
		int sum = 0;

		while (n > 0)
		{
			sum += n % 10;

			n /= 10;
		}

		return sum;
	}
}