using System;

// https://leetcode.com/problems/shortest-distance-to-a-character/
public partial class Solution
{
    public int[] ShortestToChar(string S, char C)
    {
        int[] distance = new int[S.Length];

        // Two passes
        int counter = S.Length - 1;
        for (int i = 0; i < S.Length; i++)
        {
            if (S[i] == C)
                counter = 0;
            else
                counter++;

            distance[i] = counter;
        }

        for (int i = S.Length - 1; i >= 0; i--)
        {
            if (S[i] == C)
                counter = 0;
            else
                counter++;

            distance[i] = Math.Min(distance[i], counter);
        }

        return distance;
    }
}
