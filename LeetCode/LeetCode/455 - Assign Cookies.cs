using System;

// https://leetcode.com/problems/assign-cookies/
public partial class Solution
{
    public int FindContentChildren(int[] kids, int[] cookies)
    {
        Array.Sort(kids);
        Array.Sort(cookies);

        int currentKidIndex = 0;

        for (int i = 0; i < cookies.Length && currentKidIndex < kids.Length; i++)
        {
            if (cookies[i] >= kids[currentKidIndex])
            {
                currentKidIndex++;
            }
        }

        return currentKidIndex;
    }
}
