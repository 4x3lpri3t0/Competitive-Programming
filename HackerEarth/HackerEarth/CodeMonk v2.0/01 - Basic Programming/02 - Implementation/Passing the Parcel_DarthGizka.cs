using System;
using System.Linq;

public class Passing_the_Parcel_DarthGizka
{
    const int B = 1 << 12, M = B - 1;

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine().Trim());
        var s = Console.ReadLine().Trim();
        var a = Enumerable.Range(1, B).ToArray();
        int r = 0;

        for (int i = 0, w = n; r != w; r = (r + 1) & M)
        {
            if (s[i] != 'b')
            {
                a[w] = a[r];
                w = (w + 1) & M;
            }

            if (++i == s.Length)
                i = 0;
        }

        Console.WriteLine(a[r - 1]);
    }
}