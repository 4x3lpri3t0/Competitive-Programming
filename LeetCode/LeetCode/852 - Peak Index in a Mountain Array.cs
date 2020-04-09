// https://leetcode.com/problems/peak-index-in-a-mountain-array/
public partial class Solution
{
    public int PeakIndexInMountainArray(int[] A)
    {
        int lo = 0;
        int hi = A.Length - 1;
        int mid = hi / 2;
        while (lo < hi)
        {
            if (A[mid] < A[mid + 1])
                // Is going to increase, go right
                lo = mid + 1;
            else
                // Is going to decrease, go left
                hi = mid;
            mid = lo + (hi - lo) / 2;
        }

        return lo;
    }
}