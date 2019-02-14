using System;

// https://leetcode.com/problems/assign-cookies/
public partial class Solution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        int currentKidIndex = 0;

        Array.Sort(g);
        Array.Sort(s);

        for (int i = 0; i < s.Length && currentKidIndex < g.Length; i++)
        {
            if (s[i] >= g[currentKidIndex])
            {
                currentKidIndex++;
            }
        }

        return currentKidIndex;
    }
}
