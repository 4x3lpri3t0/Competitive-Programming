// https://leetcode.com/problems/valid-mountain-array/
public partial class Solution
{
    public bool ValidMountainArray(int[] A)
    {
        if (A.Length < 3)
            return false;

        bool increasing = false;
        bool decreasing = false;
        for (int i = 1; i < A.Length; i++)
        {
            if (A[i] > A[i - 1])
            {
                if (decreasing)
                    return false;

                increasing = true;
            }
            else if (A[i] < A[i - 1])
            {
                if (!increasing)
                    return false;

                decreasing = true;
            } else // (A[i] == A[i - 1])
                return false;
        }

        if (increasing && decreasing)
            return true;

        return false;
    }
}
