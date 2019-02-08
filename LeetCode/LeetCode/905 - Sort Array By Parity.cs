// https://leetcode.com/problems/sort-array-by-parity/
public partial class Solution
{
    public int[] SortArrayByParity(int[] A)
    {
        int[] newArray = new int[A.Length];
        int l = 0; // Left pointer
        int r = A.Length - 1; // Right pointer
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] % 2 == 0)
            {
                newArray[l] = A[i];
                l++;
            }
            else
            {
                newArray[r] = A[i];
                r--;
            }
        }

        return newArray;
    }
}
