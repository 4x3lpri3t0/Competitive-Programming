using System;

// https://leetcode.com/problems/minimum-cost-for-tickets/
public partial class Solution
{
    //int[] days;
    //int[] costs;

    //public int MincostTickets(int[] d, int[] c)
    //{
    //    days = d;
    //    costs = c;

    //    return MinCost(0, 0, 0);
    //}

    //int MinCost(int accum, int limit, int currentDayIdx)
    //{
    //    if (currentDayIdx >= days.Length)
    //        return accum;

    //    if (days[currentDayIdx] < limit)
    //        return MinCost(accum, limit, currentDayIdx + 1);

    //    return Math.Min(
    //        MinCost(accum + costs[0], days[currentDayIdx] + 1, currentDayIdx + 1),
    //        Math.Min(
    //            MinCost(accum + costs[1], days[currentDayIdx] + 7, currentDayIdx + 1),
    //            MinCost(accum + costs[2], days[currentDayIdx] + 30, currentDayIdx + 1)));
    //}

    public int MincostTickets(int[] d, int[] c)
    {
        // TODO: DP bottom-up approach

        // days 
        // costs (foreach)
        
        // cache??
    }
}
