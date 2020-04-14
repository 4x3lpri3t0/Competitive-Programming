using System;
// https://leetcode.com/problems/reverse-string/
public partial class Solution
{
    public void ReverseString(char[] s)
    {
        //Array.Reverse(s); // Alternative:

        for (int i = 0; i < s.Length / 2; i++)
        {
            char temp = s[i];
            s[i] = s[s.Length - 1 - i];
            s[s.Length - 1 - i] = temp;
        }
    }
}