// https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/530/week-3/3301/
using System;

public partial class Solution
{
	public bool CheckValidString(string s)
	{
        int leftMin = 0, leftMax = 0;
        foreach (var ch in s)
        {
            if (ch == '(')
            {
                leftMin++;
                leftMax++;
            }
            else if (ch == ')')
            {
                leftMin = Math.Max(leftMin - 1, 0);
                leftMax--;

                if (leftMax < 0)
                    return false;
            }
            else
            {
                leftMin = Math.Max(leftMin - 1, 0);
                leftMax++;
            }
        }

        return leftMin == 0;
    }
}