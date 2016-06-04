using System;
using System.Numerics;

namespace _HackerRankSln._Algorithms._08___Dynamic_Programming
{
    public static class Fibonacci_Modified
    {
        // This solution doesn't actually use DP
        // TODO: Do one that does
        public static void _Main()
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            BigInteger A = input[0];
            BigInteger B = input[1];
            int N = input[2];

            BigInteger nth = 0;
            for (int i = 3; i <= N; i++)
            {
                nth = B * B + A;
                A = B;
                B = nth;
            }

            Console.WriteLine(nth);
        }
    }
}
