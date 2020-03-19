using System;

// https://www.hackerrank.com/challenges/crush/problem

public static class ArrayManipulation
{
	public static long ArrayMan(int n, int[][] queries)
	{
		long[] A = new long[n];
		
		// Store diff
		for (int row = 0; row < queries.Length; row++)
		{
			int a = queries[row][0] - 1;
			int b = queries[row][1]; // Not converting to 0-index since we will add to following one anyways
			int k = queries[row][2];

			A[a] += k;
			
			if (b < n)
				A[b] -= k;
		}

		long max = A[0];
		// Track max + dp
		for (int i = 1; i < n; i++)
		{
			A[i] = A[i - 1] + A[i];
			max = Math.Max(max, A[i]);
		}

		return max;
	}
}