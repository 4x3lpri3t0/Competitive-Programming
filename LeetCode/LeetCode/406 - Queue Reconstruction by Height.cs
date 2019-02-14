using System;
using System.Collections.Generic;

// https://leetcode.com/problems/queue-reconstruction-by-height/
public partial class Solution
{
    public int[,] ReconstructQueue(int[,] people)
    {
        #region Annoying conversion to jagged array
        int[][] pp = new int[people.GetLength(0)][];
        for (int i = 0; i < pp.Length; i++)
        {
            pp[i] = new int[2];
            pp[i][0] = people[i, 0];
            pp[i][1] = people[i, 1];
        }
        #endregion

        // Equal height ? people in front : height
        Array.Sort(pp, (x, y) => x[0] == y[0] ?
                  x[1] - y[1] : y[0] - x[0]);

        // Greedily insert people according to people in front
        List<int[]> ans = new List<int[]>();
        for (int i = 0; i < pp.Length; i++)
        {
            ans.Insert(pp[i][1], pp[i]);
        }

        #region Annoying conversion to rectangular array
        for (int i = 0; i < pp.Length; i++)
        {
            people[i, 0] = ans[i][0];
            people[i, 1] = ans[i][1];
        }
        #endregion
        return people;
    }
}
