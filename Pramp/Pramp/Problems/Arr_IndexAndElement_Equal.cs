using System;
using System.Diagnostics;
using System.Timers;

/*

Array Index & Element Equality

Given an array of sorted distinct integers named arr,
write a function that returns an index i in arr for which arr[i] = i
or -1 if no such index exists.

Implement the most efficient solution possible,
prove the correctness of your solution and
analyze its runtime complexity (in terms of n - the length of arr).

Examples:

Given arr = [-8,0,2,5] the function returns 2, since arr[2] = 2
Given arr = [-1,0,3,6] the function returns -1, since no index in arr satisfies arr[i] = i

*/

public class Arr_IndexAndElement_Equal
{
    public static void Main()
    {
        var test1 = new int[] { -8, 0, 2, 5 };
        var test2 = new int[] { -1, 0, 3, 6 };

        Debug.Assert(BinarySearch(test1, 0, test1.Length - 1) == 2);
        Debug.Assert(BinarySearch(test2, 0, test2.Length - 1) == -1);
    }

    private static int LinearSearch(int[] A)
    {
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == i)
            {
                return i;
            }
        }

        return -1;
    }

    private static int BinarySearch(int[] arr, int low, int high)
    {
        if (high >= low)
        {
            int mid = (low + high) / 2;  /* low + (high - low) / 2; */
            if (mid == arr[mid])
            {
                return mid;
            }

            if (mid > arr[mid])
            {
                return BinarySearch(arr, (mid + 1), high);
            }

            return BinarySearch(arr, low, (mid - 1));
        }

        return -1;
    }
}