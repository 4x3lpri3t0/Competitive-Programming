using System;

// https://www.hackerrank.com/challenges/sparse-arrays

public static class Sparse_Arrays
{
    public static void PrintTimes()
    {
        int N, Q;
        string[] stringArray;
        Input(out N, out stringArray, out Q);

        for (int i = 0; i < Q; i++)
        {
            string query = Console.ReadLine();
            int appearances = 0;
            for (int j = 0; j < N; j++)
            {
                if (string.Equals(stringArray[j], query))
                {
                    appearances++;
                }
            }

            Console.WriteLine(appearances);
        }
    }

    private static void Input(out int N, out string[] stringArray, out int Q)
    {
        N = Convert.ToInt32(Console.ReadLine());
        stringArray = new string[N];
        for (int i = 0; i < N; i++)
        {
            string temp = Console.ReadLine();
            stringArray[i] = temp;
        }
        Q = Convert.ToInt32(Console.ReadLine());
    }
}