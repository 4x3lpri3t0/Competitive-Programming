using System;

// https://codeforces.com/problemset/problem/1/A
public static class Theatre_Square
{
    public static void Main()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int n = input[0];
        int m = input[1];
        int a = input[2];

        decimal nOfAtoCoverN = Math.Ceiling((decimal)n / a);
        decimal nOfAtoCoverM = Math.Ceiling((decimal)m / a);
        Console.WriteLine(nOfAtoCoverN * nOfAtoCoverM);
    }
}
