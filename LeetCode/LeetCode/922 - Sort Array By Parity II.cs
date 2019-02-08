// https://leetcode.com/problems/sort-array-by-parity-ii/
public partial class Solution
{
    public int[] SortArrayByParityII(int[] A)
    {
        int evenIdx = 0;
        int oddIdx = 1;
        int[] newA = new int[A.Length];
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] % 2 == 0)
            {
                newA[evenIdx] = A[i];
                evenIdx += 2;
            }
            else
            {
                newA[oddIdx] = A[i];
                oddIdx += 2;
            }
        }

        return newA;
    }
}
