using System;
using System.Numerics;

// TODO: Seek for a solution that does actually use DP
// https://www.hackerrank.com/challenges/fibonacci-modified

public static class Fibonacci_Modified
{
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