using System.Diagnostics;
using System.Linq;

/*

Array of Array Products

Given an array of integers arr, write a function that returns another array
at the same length where the value at each index i is the product of
all arrayvalues except arr[i].

Solve without using division and analyze the runtime and space complexity.

Example: given the array [2,  7,  3,  4] your function would return: [84, 24, 56, 42]
(by calculating: [7*3*4, 2*3*4, 2*7*4, 2*7*3])

*/

public class Array_of_Array_Products
{
    public static void Main()
    {
        int[] test = { 2, 7, 3, 4 };

        var result = GetProductsExceptAtIndex(test);
        int[] expected = { 84, 24, 56, 42 };
        Debug.Assert(Enumerable.SequenceEqual(result, expected));
    }

    private static int[] GetProductsExceptAtIndex(int[] intArray)
    {
        int[] productsExceptAtIndex = new int[intArray.Length];

        // Find product of all the integers before it
        int productSoFar = 1;
        for (int i = 0; i < intArray.Length; i++)
        {
            productsExceptAtIndex[i] = productSoFar;
            productSoFar *= intArray[i];
        }

        // Find product of all the integers after it
        productSoFar = 1;
        for (int i = intArray.Length - 1; i >= 0; i--)
        {
            productsExceptAtIndex[i] *= productSoFar;
            productSoFar *= intArray[i];
        }

        return productsExceptAtIndex;
    }
}

/*

A greedy algorithm iterates through the problem space taking the optimal solution
"so far," until it reaches the end.

The greedy approach is only optimal if the problem has "optimal substructure,"
which means stitching together optimal solutions to subproblems yields
an optimal solution.

Complexity
==========

O(n) time and O(n) space. We make two passes through our input a list,
and the list we build always has the same length as the input list.

Learned
=======

Start with a brute force solution, look for repeat work in that solution,
and modify it to only do that work once.

*/