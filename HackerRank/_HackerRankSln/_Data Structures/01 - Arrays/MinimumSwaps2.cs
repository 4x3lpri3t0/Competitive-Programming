// https://www.hackerrank.com/challenges/minimum-swaps-2
using System;

public class MinimumSwaps2
{
	public static int MinimumSwaps(int[] arr)
	{
		int totalSwaps = 0;

		for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i] == i + 1)
				continue;

			while (arr[i] != i + 1)
			{
				// Need to swap
				int temp = arr[i];
				arr[i] = arr[arr[i] - 1];
				arr[temp - 1] = temp;

				totalSwaps++;
			}
		}

		return totalSwaps;
	}
}
