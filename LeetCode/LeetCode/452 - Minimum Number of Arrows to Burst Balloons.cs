using System;

// https://leetcode.com/problems/minimum-number-of-arrows-to-burst-balloons/
partial class Solution
{
    public int FindMinArrowShots(int[,] pointsOriginal)
    {
        #region Convert to jagged array
        var points = new int[pointsOriginal.GetLength(0)][];
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = new int[2];
            points[i][0] = pointsOriginal[i, 0];
            points[i][1] = pointsOriginal[i, 1];
        }
        #endregion

        // Sort the array of balloons by ending position
        Array.Sort(points, (a, b) => (a[1] - b[1]));

        int previousEnd = points[0][1];
        int arrowCnt = 1;
        for (int i = 1; i < points.Length; i++)
        {
            var currentStart = points[i][0];
            if (currentStart > previousEnd)
            {
                // If the balloon's starting position isn't in the range
                // then add the counter and update the arrowPos
                arrowCnt++;

                previousEnd = points[i][1];
            }
        }

        return arrowCnt;
    }
}