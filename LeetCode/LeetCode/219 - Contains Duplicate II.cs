// https://leetcode.com/problems/contains-duplicate-ii/
using System.Collections.Generic;

public partial class Solution
{
	public bool ContainsNearbyDuplicate(int[] nums, int k)
	{
		var set = new HashSet<int>();

		for (int i = 0, j = 0; j < nums.Length; j++)
		{
			if (j - i > k)
			{
				set.Remove(nums[i]);
				i++;
			}

			if (set.Contains(nums[j]))
				return true;
			else
				set.Add(nums[j]);
		}

		return false;
	}
}