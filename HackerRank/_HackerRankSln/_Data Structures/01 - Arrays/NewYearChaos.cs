using System;

// https://www.hackerrank.com/challenges/new-year-chaos/

public static class NewYearChaos
{
	static void MinimumBribes(int[] q)
	{
		int n = q.Length;
		int cnt = 0;
		for (int i = n - 1; i >= 0; i--)
		{
			if (q[i] == (i + 1))
				continue;

			// There is a number in front && it belongs to current pos (bribed 1)
			if (((i - 1) >= 0) && q[i - 1] == (i + 1))
			{
				cnt++;

				// Restore order for next iteration (discard briber)
				q[i - 1] = q[i];
			}
			// There are two numbers in front && it belongs to current pos (bribed 2)
			else if (((i - 2) >= 0) && q[i - 2] == (i + 1))
			{
				cnt += 2;

				// Restore order for next iterations (discard briber)
				q[i - 2] = q[i - 1];
				q[i - 1] = q[i];
			}
			else
			{
				Console.WriteLine("Too chaotic");
				return;
			}
		}

		Console.WriteLine(cnt);
	}
}