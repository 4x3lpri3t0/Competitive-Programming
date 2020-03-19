using System;

// https://www.hackerrank.com/challenges/new-year-chaos/

public static class NewYearChaos
{
    private static void Swap(int[] A, int idxA, int idxB)
    {
        int temp = A[idxA];
        A[idxA] = A[idxB];
        A[idxB] = temp;
    }

    static void MinimumBribes(int[] A)
    {
        int n = A.Length;
        int cnt = 0;
        for (int i = n - 1; i >= 0; i--)
        {
            if (A[i] != (i + 1))
            {
                if (((i - 1) >= 0) && A[i - 1] == (i + 1))
                {
                    cnt++;
                    Swap(A, A[i], A[i - 1]);
                }
                else if (((i - 2) >= 0) && A[i - 2] == (i + 1))
                {
                    cnt += 2;
                    A[i - 2] = A[i - 1];
                    A[i - 1] = A[i];
                    A[i] = i + 1;
                }
                else
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
            }
        }

        Console.WriteLine(cnt);
    }
}