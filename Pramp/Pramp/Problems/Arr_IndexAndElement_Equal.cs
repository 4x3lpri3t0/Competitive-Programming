using System;

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
        Console.WriteLine(Solver(test1));
        Console.WriteLine(Solver(test2));
    }

    private static int Solver(int[] A)
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
}