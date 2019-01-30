using System;

// https://codeforces.com/problemset/problem/4/A
public static class Watermelon
{
    public static void Main()
    {
        int w = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(w > 2 && w % 2 == 0 ? "YES" : "NO");
    }
}