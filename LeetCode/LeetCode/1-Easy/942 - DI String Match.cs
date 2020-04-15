// https://leetcode.com/problems/di-string-match/
public partial class Solution
{
    public int[] DiStringMatch(string S)
    {
        int l = 0;
        int N = S.Length;
        int r = N;
        int[] result = new int[N + 1];
        for (int i = 0; i < N; i++)
        {
            if (S[i] == 'I')
            {
                result[i] = l;
                l++;
            }
            else // 'D'
            {
                result[i] = r;
                r--;
            }
        }

        result[N] = l;

        return result;
    }
}
