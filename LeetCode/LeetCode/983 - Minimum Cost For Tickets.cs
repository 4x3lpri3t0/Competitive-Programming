using System;
using System.Collections.Generic;

// https://leetcode.com/problems/minimum-cost-for-tickets/
public partial class Solution
{
    int[] costs;
    int[] memo;
    HashSet<int> dayset;

    public int MincostTickets(int[] days, int[] costs)
    {
        this.costs = costs;
        memo = new int[366];
        dayset = new HashSet<int>(days);

        return Dp(1);
    }

    int Dp(int i)
    {
        if (i > 365)
            return 0;
        if (memo[i] != 0)
            return memo[i];

        int ans;
        if (dayset.Contains(i))
        {
            ans = Math.Min(Dp(i + 1) + costs[0], Dp(i + 7) + costs[1]);
            ans = Math.Min(ans, Dp(i + 30) + costs[2]);
        }
        else
            ans = Dp(i + 1);

        memo[i] = ans;
        return ans;
    }
}
