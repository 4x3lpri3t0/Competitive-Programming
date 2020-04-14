// https://leetcode.com/problems/n-repeated-element-in-size-2n-array/
public partial class Solution
{
    public int RepeatedNTimes(int[] A)
    {
        for (int i = 0; i < A.Length - 2; i++)
        {
            if (A[i] == A[i + 1] || A[i] == A[i + 2])
            {
                return A[i];
            }
        }

        return A[A.Length - 1];
    }
}
