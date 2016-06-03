using System;

namespace _HackerRankSln._30DaysOfCode
{
    public static class Day_11___2DArrays
    {
        public static void _Main()
        {
            int length = 6;
            var hg = new int[length][];

            for (int i = 0; i < length; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int [] array = Array.ConvertAll(input, int.Parse);
                hg[i] = array;
            }

            int maxSum = int.MinValue;
            for (int i = 0; i < length - 2; i++)
            {
                for (int j = 0; j < length - 2; j++)
                {
                    int row1 = hg[i][j] + hg[i][j + 1] + hg[i][j + 2];
                    int row2 = hg[i + 1][j + 1];
                    int row3 = hg[i + 2][j] + hg[i + 2][j + 1] + hg[i + 2][j + 2];

                    int sum = row1 + row2 + row3;
                    maxSum = sum > maxSum ? sum : maxSum;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
