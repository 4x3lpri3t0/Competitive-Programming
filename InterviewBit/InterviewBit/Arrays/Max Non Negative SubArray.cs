using System;
using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    public List<int> maxset(List<int> A)
    {
        var listOfLists = new List<List<long>>();

        var tempList = new List<long>();
        foreach (int elem in A)
        {
            if (elem < 0)
            {
                listOfLists.Add(tempList);
                tempList = new List<long>();
            }
            else
            {
                tempList.Add((long)elem);
            }
        }
        listOfLists.Add(tempList);

        // Detect max sum array
        var maxList = new List<long>();
        long maxSum = -1;
        foreach (var list in listOfLists)
        {
            long sum = list.Sum(x => x);
            if (sum > maxSum)
            {
                maxList = list;
                maxSum = sum;
            }
        }

        return maxList.Select(x => Convert.ToInt32(x)).ToList<int>();
    }
}