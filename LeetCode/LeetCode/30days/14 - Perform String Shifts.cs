// https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/529/week-2/3299/
using System;

public partial class Solution
{
    public string StringShift(string s, int[][] shift)
    {
        int totalMoves = 0;
        // Add or substract depending on direction
        for (int i = 0; i < shift.Length; i++)
        {
            if (shift[i][0] == 0) // Left
                totalMoves -= shift[i][1];
            else // Right
                totalMoves += shift[i][1];
        }

        // Modulo
        totalMoves %= s.Length;

        // To the left
        // abc -> bc a
        if (totalMoves < 0)
        {
            totalMoves = Math.Abs(totalMoves);
            string part1 = s.Substring(0, totalMoves);
            string part2 = s.Substring(totalMoves);

            return part2 + part1;
        }
        else
        {
            // To the right
            // abc -> c ab
            string part1 = s.Substring(0, s.Length - totalMoves);
            string part2 = s.Substring(s.Length - totalMoves);

            return part2 + part1;
        }
        
    }
}