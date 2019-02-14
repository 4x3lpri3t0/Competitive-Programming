// https://leetcode.com/problems/monotonic-array/
public partial class Solution
{
    public bool IsMonotonic(int[] A)
    {
        int direction = 0;

        for (int i = 1; i < A.Length; i++)
        {
            if (direction == 0)
            {
                if (A[i] > A[i - 1])
                    direction = 1; // Increasing
                else if (A[i] < A[i - 1])
                    direction = -1; // Decreasing
                // If equal, do nothing
            }
            else // Direction was already set
            {
                if (direction == 1) // Increasing
                {
                    if (A[i] < A[i - 1])
                        return false;
                }
                else // Direction -1 (Decreasing)
                {
                    if (A[i] > A[i - 1])
                        return false;
                }
            }
        }

        return true;
    }
}
