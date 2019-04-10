using System;

// https://leetcode.com/problems/minimum-falling-path-sum/
public partial class Solution
{
    int[][] matrix;

    public int MinFallingPathSum(int[][] A)
    {
        for (int i = 1; i < A.Length; i++)
        {
            for (int j = 0; j < A[0].Length; j++)
            {
                int min = int.MaxValue;
                for (int k = Math.Max(0, j - 1); k < Math.Min(j + 2, A[0].Length); k++)
                {
                    min = Math.Min(min, A[i - 1][k]);
                }
                A[i][j] = A[i][j] + min;
            }
        }

        int totalMin = int.MaxValue;
        for (int i = 0; i < A[0].Length; i++)
        {
            totalMin = Math.Min(totalMin, A[A.Length - 1][i]);
        }

        return totalMin;
    }
}
