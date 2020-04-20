// https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/530/week-3/3304/
public partial class Solution
{
	public int Search(int[] numbers, int target)
	{
		if (numbers == null || numbers.Length == 0)
			return -1;

		var length = numbers.Length;
		int start = 0;
		int end = length - 1;
		while (start <= end)
		{
			var middle = (start + end) / 2;
			var middleValue = numbers[middle];

			if (middleValue == target)
				return middle;

			var firstHalfAscending = middleValue >= numbers[start];
			if (firstHalfAscending)
			{   // in range 
				if (target >= numbers[start] && target < middleValue)
					// remove right half
					end = middle - 1;
				else
					start = middle + 1;
			}
			else
			{
				// in range 
				if (target > middleValue && target <= numbers[end])
					// remove left half
					start = middle + 1;
				else
					end = middle - 1;
			}
		}

		return -1;
	}
}