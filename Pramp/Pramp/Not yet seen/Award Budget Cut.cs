using System;

// URL ???
partial class Solution
{
    public static double FindGrantsCap(double[] grantsArray, double newBudget)
    {
        if (grantsArray == null || grantsArray.Length == 0)
            return -1;

        Array.Sort(grantsArray); // 2, 50, 100, 120, 1000

        int length = grantsArray.Length;
        double sum = 0;
        for (int i = 0; i < length; i++)
        {
            var current = grantsArray[i]; // 2, 50
            var number = (length - i); // 5, 4

            // Check if current needs to be cut or not
            bool needCut = (sum + current * number) > newBudget; // 0 + 2 * 5 vs 190 , 2 + 50 * 4 vs 190
            if (needCut)
                return (newBudget - sum) / number; // 190 - 2/ 4 = 47

            sum += current; // sum = 2
        }

        return grantsArray[length - 1];
    }

    public static void AwardBudgetCut()
    {
        var newCut = FindGrantsCap(new double[] { 2, 100, 50, 120, 1000 }, 190);
        Console.WriteLine(newCut);
    }
}

// 2, 100, 50, 120, 1000, new budget = 190
// least number of recipients - 
// sorted number
// 2, 50, 100, 120, 1000 - > 190 
// 2, afford, 5, 2  = 10 < 190 
// 2, 50, >=50, 4 of 50, 2 + 200 < 190 
// 190 - 2 = 188, 188 spread 4 element 188/4 = 47
// time complexity: O(nlogn) + O(n) = O(nlogn), newBudget 