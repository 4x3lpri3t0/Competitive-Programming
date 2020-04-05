// https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/528/week-1/3286/
public partial class Solution
{
	public void MoveZeroes(int[] nums)
	{
		int zeroes = 0;
		int write = 0;
		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] == 0)
				zeroes++;
			else
				nums[write++] = nums[i];
		}

		// > .NET Core 2.0
		// Array.Fill(nums, 0, nums.Length - zeros, zeros);

		// Older .NET
		for (int i = nums.Length - zeroes; i < nums.Length; i++)
		{
			nums[i] = 0;
		}
	}
}