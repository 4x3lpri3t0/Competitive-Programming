// https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/528/week-1/3284/
using System;
using System.Collections.Generic;

public partial class Solution
{
    public bool IsHappy(int n)
    {
        var seen = new HashSet<int>();

        do
        {
            seen.Add(n);
            int sum = GetSquaredSum(n);

            if (sum == 1)
                return true;

            n = sum;
        } while (!seen.Contains(n));

        return false;
    }

    private static int GetSquaredSum(int n)
    {
        // Square every digit and accumulate sum
        int sum = 0;
        while (n > 0)
        {
            sum += (int)Math.Pow(n % 10, 2);
            n /= 10;
        }

        return sum;
    }
}