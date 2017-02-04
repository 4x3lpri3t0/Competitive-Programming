using System;
using System.Collections.Generic;

public partial class Solution
{
    public int repeatedNumber(List<int> A)
    {
        int[] array = new int[A.Count];

        foreach (var element in A)
        {
            if (array[element] == 0)
            {
                array[element] = 1;
            }
            else
            {
                return element;
            }
        }

        return -1;
    }
}