using System;

// https://www.hackerrank.com/challenges/maximum-draws

public class Maximum_Draws
{
    public static void MaxDraws()
    {
        int T = Convert.ToInt32(Console.ReadLine());
        while (T-- != 0)
        {
            long N = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(N + 1);
        }
    }
}