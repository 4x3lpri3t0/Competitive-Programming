using System;

namespace _HackerRankSln._Algorithms._01___Warmup_Problems
{
    public static class Diagonal_Difference
    {
        public static int DiagonalDiff()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            int firstSum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                firstSum += a[i][i];
            }

            int secondSum = 0,
                j = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                secondSum += a[j][i];
                j++;
            }

            return Math.Abs(firstSum - secondSum);
        }
    }
}
