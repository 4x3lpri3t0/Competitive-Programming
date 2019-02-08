using System;

// https://leetcode.com/problems/k-closest-points-to-origin/
public partial class Solution
{
    public int[][] KClosest(int[][] points, int K)
    {
        Array.Sort(points, (p1, p2) => p1[0] * p1[0] + p1[1] * p1[1] - p2[0] * p2[0] - p2[1] * p2[1]);
        var copy = new int[K][];

        // Copy the first K points
        Array.Copy(points, copy, K);

        return copy;
    }
}
