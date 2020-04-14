// https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/529/week-2/3297/
using System;

public partial class Solution
{
	public int LastStoneWeight(int[] stones)
	{
		for (int i = 0; i < stones.Length - 1; i++)
		{
			Array.Sort(stones);
			Array.Reverse(stones);
			stones[0] = stones[0] - stones[1];
			stones[1] = 0;
		}
		return stones[0];
	}
}