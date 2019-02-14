using System.Text;

// https://leetcode.com/problems/string-without-aaa-or-bbb/
public partial class Solution
{
    public string StrWithout3a3b(int A, int B)
    {
        StringBuilder res = new StringBuilder(A + B);
        char hi = 'a', lo = 'b';
        int i = A, j = B;

        if (B > A) {
            hi = 'b';
            lo = 'a';
            i = B;
            j = A;
        }

        while (i-- > 0)
        {
            res.Append(hi);
            if (i > j) {
                res.Append(hi);
                i--;
            }

            if (j-- > 0)
                res.Append(lo);
        }

        return res.ToString();
    }
}