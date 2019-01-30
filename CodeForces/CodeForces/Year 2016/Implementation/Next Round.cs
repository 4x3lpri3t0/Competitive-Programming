using System;
using System.Linq;

// https://codeforces.com/problemset/problem/158/A
public static class Next_Round
{
    public static void Main()
    {
        int[] inputRow = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int k = inputRow[1];
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int kValue = a[k - 1];
        int passing = a.Where(x => x >= kValue).Count();

        Console.WriteLine(passing);
    }
}
