using System;
using System.Linq;

/*

Award Budget Cuts
=================

The awards committee had planned to give 'n' research grants this year,
out of 'a' its total yearly budget. However, the budget was reduced to 'b' dollars.

The committee members has decided to affect the minimal number of highest grants,
by applying a maximum cap 'c' on all grants: every grant that was planned to be higher
than 'c' will now be 'c' dollars.

Help the committee to choose the right value of 'c' that would make the
total sum of grants equal to the new budget.

Given an array of grants 'g' and a new budget 'b', explain and code an efficient
method to find the cap 'c'.

Assume that each grant is unique.

*/

public class Budget_Cuts
{
    public static void Main()
    {
        Console.WriteLine(FindCap(new int[] { 10, 30, 50, 70, 120, 150 }, 240));

        ////FindCap([10, 30, 50, 70, 120, 150], 240)
        ////50
        ////FindCap([10, 30, 50, 70, 120, 150], 1000)
        ////0
    }

    private static int FindCap(int[] grants, int newBudget)
    {
        // Validate input
        if (grants.Length == 0 || newBudget <= 0)
        {
            return 0;
        }

        /*

        n = length(g)
        partialSums = []
        tempSum = 0
        for (i from 0 to n-1):
            tempSum = tempSum + g[i]
            partialSums[i] = tempSum
        if (partialSums[n-1] <= b):
            return g[n-1]
 
        function cappedSum(i):
            return partialSums[i-1] + g[i]*(n-i)
 
        start = 0
        end   = n-1
        while (end > start):
            r = floor((end+start)/2)
            if (r > 0):
                if (cappedSum(r) > b):
                if (cappedSum(r-1) < b):
                    break
                else:
                    end = r - 1
                else:
                start = r + 1
 
        c = (b - partialSums[r-1]) / (n-r)
        return c

        */

        int c = 0;
        int oldBudgets = grants.Sum();
        int offset = oldBudgets - newBudget;

        // We sort the array first
        grants = grants.OrderByDescending(x => x).ToArray();

        // Binary Search


        return c;
    }
}

// Linear scan is possible but not optimal
// A better approach is Binary search

/*

Runtime Complexity:
==================

Since we know nothing about the grants, sorting the grants takes O(n∙log n).
Pre-computation over the grants is a linear O(n).
Binary search is O(log n) because the reminder to search in is divided by 2
at each iteration.

Total complexity is a linear O(n) for sorted grants or O(n ∙ log n) for non-sorted.
 
Space Complexity:
================

O(n) for using another array for pre-computations.
If short in memory space to store this, we avoid the pre-computation
and do a linear iteration for each cappedSum calculation.


This would make the space complexity O(1) and the runtime complexity O(n∙log n).

*/
