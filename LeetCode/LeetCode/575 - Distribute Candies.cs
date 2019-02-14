using System;
using System.Collections.Generic;

// https://leetcode.com/problems/distribute-candies/
public partial class Solution
{
    public int DistributeCandies(int[] candies)
    {
        var set = new HashSet<int>(candies);
        return Math.Min(set.Count, candies.Length / 2);
    }
}
