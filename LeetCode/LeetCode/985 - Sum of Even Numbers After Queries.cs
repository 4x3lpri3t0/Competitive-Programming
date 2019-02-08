// https://leetcode.com/problems/sum-of-even-numbers-after-queries/
public partial class Solution
{
    public int[] SumEvenAfterQueries(int[] A, int[][] queries)
    {
        int evenSum = 0;
        for (int i = 0; i < A.Length; i++)
        {
            evenSum += (A[i] % 2 == 0 ? A[i] : 0);
        }

        int[] results = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            int val = queries[i][0];
            int idx = queries[i][1];

            int newVal = A[idx] + val;
            if (A[idx] % 2 == 0 && newVal % 2 != 0)
                evenSum -= A[idx]; // We lost an even
            else if (A[idx] % 2 == 0 && newVal % 2 == 0)
                evenSum += val; // We increased an even
            else if (A[idx] % 2 != 0 && newVal % 2 == 0)
                evenSum += newVal; // We gained an even

            A[idx] = newVal;
            results[i] = evenSum;
        }

        return results;
    }
}
