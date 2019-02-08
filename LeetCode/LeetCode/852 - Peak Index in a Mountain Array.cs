// https://leetcode.com/problems/peak-index-in-a-mountain-array/
public partial class Solution
{
    public int PeakIndexInMountainArray(int[] A)
    {
        int max = 0;
        int idx = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] > max)
            {
                max = A[i];
                idx = i;
            }
        }

        return idx;
    }
}
