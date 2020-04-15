// https://leetcode.com/problems/maximum-number-of-events-that-can-be-attended/
using System;
using System.Linq;

// TODO: Fix - Idea: Repeat from the end?
public partial class Solution
{
	public int MaxEvents(int[][] events)
	{
		// Order by finish time
		events = events.OrderBy(x => x[1]).ToArray();

		int attended = 0;
		int availableDay = 1;
		// Greedily attend the soonest possible
		foreach (var ev in events)
		{
			if (availableDay <= ev[1]) // Can attend
			{
				attended++;
				availableDay = Math.Max(availableDay + 1, ev[0] + 1);
			}
		}

		return attended;
	}
}