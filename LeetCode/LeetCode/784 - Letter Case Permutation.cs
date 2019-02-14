using System.Collections.Generic;

// https://leetcode.com/problems/letter-case-permutation/
public partial class Solution
{
    public IList<string> LetterCasePermutation(string s)
    {
        var a = s.ToCharArray();
        var ans = new List<string>();
        Rec(a, 0, ans);

        return ans;
    }

    private void Rec(char[] a, int index, IList<string> ans)
    {
        if (index == a.Length)
        {
            ans.Add(new string(a));
            return;
        }
        else if ('0' <= a[index] && a[index] <= '9')
        {
            Rec(a, index + 1, ans);
        }
        else
        {
            a[index] = char.ToLower(a[index]);
            Rec(a, index + 1, ans);
            a[index] = char.ToUpper(a[index]);
            Rec(a, index + 1, ans);
        }
    }
}
