using System;

// https://www.hackerrank.com/challenges/taum-and-bday

public static class Taum_and_B_day
{
    public static void GiftCalculator()
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            // factor -> conversion cost
            long b, w, bCost, wCost, factor;
            GetInput(out b, out w, out bCost, out wCost, out factor);

            long minB = Math.Min(b * bCost, b * (wCost + factor));
            long minW = Math.Min(w * wCost, w * (bCost + factor));

            Console.WriteLine(minB + minW);
        }
    }

    private static void GetInput(out long b, out long w, out long bCost, out long wCost, out long factor)
    {
        string[] tokens_BW = Console.ReadLine().Split(' ');
        b = Convert.ToInt64(tokens_BW[0]);
        w = Convert.ToInt64(tokens_BW[1]);
        string[] tokens_cost = Console.ReadLine().Split(' ');
        bCost = Convert.ToInt64(tokens_cost[0]);
        wCost = Convert.ToInt64(tokens_cost[1]);
        factor = Convert.ToInt64(tokens_cost[2]);
    }
}