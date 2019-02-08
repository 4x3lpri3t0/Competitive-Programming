// https://leetcode.com/problems/minimum-add-to-make-parentheses-valid/
public partial class Solution
{
    public int MinAddToMakeValid(string S)
    {
        int open = 0;
        int missing = 0;
        for (int i = 0; i < S.Length; i++)
        {
            char cur = S[i];

            if (cur == ')')
                if (open == 0)
                    missing++;
                else
                    open--;
            else
                open++;
        }

        return missing + open;
    }
}
