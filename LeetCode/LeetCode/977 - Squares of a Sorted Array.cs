// https://leetcode.com/problems/squares-of-a-sorted-Aay/
public partial class Solution
{
    public int[] SortedSquares(int[] A)
    {
        int n = A.Length;

        // First divide array into negative and positive parts
        int k;
        for (k = 0; k < n; k++)
        {
            if (A[k] >= 0)
                break;
        }

        // Now do the same process than in merge sort to merge to two sorted arrays.
        // Here both two halves are sorted and we traverse first half in reverse manner
        // because first half contains negative element
        int l = k - 1; // Initial index of first half (Left)
        int r = k; // Initial index of second half (Right)
        int index = 0; // Initial index of temp array

        int[] temp = new int[n];
        while (l >= 0 && r < n)
        {
            if (A[l] * A[l] < A[r] * A[r])
            {
                temp[index] = A[l] * A[l];
                l--;
            }
            else
            {
                temp[index] = A[r] * A[r];
                r++;
            }
            index++;
        }

        while (l >= 0)
        {
            temp[index++] = A[l] * A[l];
            l--;
        }
        while (r < n)
        {
            temp[index++] = A[r] * A[r];
            r++;
        }

        // Copy 'temp' array into original array
        for (int i = 0; i < n; i++)
            A[i] = temp[i];

        return A;
    }
}