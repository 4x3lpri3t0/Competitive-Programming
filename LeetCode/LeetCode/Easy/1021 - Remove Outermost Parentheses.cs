// https://leetcode.com/problems/remove-outermost-parentheses/
using System.Text;

public partial class Solution
{
    public string RemoveOuterParentheses(string S)
    {
        var result = new StringBuilder();
        int opened = 0;

        foreach (char cur in S)
        {
            if (cur == '(')
            {
                if (opened != 0)
                    result.Append(cur);
                opened++;
            }
            else // ')'
            {
                if (opened > 1)
                    result.Append(cur);
                opened--;
            }
        }

        return result.ToString();
    }
}