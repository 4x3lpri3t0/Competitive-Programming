﻿// https://leetcode.com/problems/delete-columns-to-make-sorted/
public partial class Solution
{
    public int MinDeletionSize(string[] A)
    {
        int count = 0;
        for (int i = 0; i < A[0].Length; i++)
        {
            for (int j = 0; j < A.Length - 1; j++)
            {
                if (A[j][i] > A[j + 1][i])
                {
                    count++;
                    break;
                }
            }
        }
        return count;
    }
}
