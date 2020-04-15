// https://leetcode.com/problems/is-subsequence/
public partial class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0)
            return true;

        int sIndex = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (s[sIndex] == t[i])
                sIndex++;

            if (sIndex == s.Length)
                return true;
        }

        return false;
    }
}
