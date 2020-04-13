// https://leetcode.com/problems/monotonic-array/
public partial class Solution
{
    public bool IsMonotonic(int[] A)
    {
        bool wasIncreasing = false;
        bool wasDecreasing = false;

        for (int i = 1; i < A.Length; i++)
        {
            if (A[i] == A[i - 1])
                continue;

            bool isIncreasing = A[i] > A[i - 1];
            bool isDecreasing = A[i] < A[i - 1];
            if (wasIncreasing && isDecreasing)
                return false;
            if (wasDecreasing && isIncreasing)
                return false;

            wasIncreasing = isIncreasing;
            wasDecreasing = isDecreasing;
        }

        return true;
    }
}
