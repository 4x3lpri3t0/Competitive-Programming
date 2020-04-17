/*
PRAMP
Deletion Distance
The deletion distance of two strings is the minimum number of characters you need to delete in the two strings
in order to get the same string. For instance, the deletion distance between "heat" and "hit" is 3:
By deleting 'e' and 'a' in "heat", and 'i' in "hit", we get the string "ht" in both cases.
We cannot get the same string from both strings by deleting 2 letters or fewer.
Given the strings str1 and str2, write an efficient function deletionDistance that returns the deletion distance between them. Explain how your function works, and analyze its time and space complexities.
Examples:
input:  str1 = "dog", str2 = "frog"
output: 3
input:  str1 = "some", str2 = "some"
output: 0
input:  str1 = "some", str2 = "thing"
output: 9
input:  str1 = "", str2 = ""
output: 0
Constraints:
[input] string str1
[input] string str2
[output] integer
*/

// TODO: https://dotnetfiddle.net/DP34N3
// https://leetcode.com/problems/delete-operation-for-two-strings/
// Pramp URL?
using System;

partial class Solution
{
    public static int GetDeletionDistance(string str1, string str2)
    {
        if (str1.Length == 0 && str2.Length != 0)
            return str2.Length;
        if (str2.Length == 0 && str1.Length != 0)
            return str1.Length;
        if (str1 == str2)
            return 0;

        var matrix = new int[str1.Length + 1, str2.Length + 1];
        for (var i = 0; i < str1.Length + 1; i++)
            matrix[i, 0] = i;
        for (var j = 0; j < str2.Length + 1; j++)
            matrix[0, j] = j;

        for (var i = 1; i < str1.Length + 1; i++)
        {
            for (var j = 1; j < str2.Length + 1; j++)
            {
                if (str1[i - 1] == str2[j - 1]) // Same
                    matrix[i, j] = matrix[i - 1, j - 1]; // Continue with next
                else
                    matrix[i, j] = Math.Min(matrix[i - 1, j], matrix[i, j - 1]) + 1;
            }
        }
        return matrix[str1.Length, str2.Length];
    }

    public static void DeletionDistance()
    {
        Console.WriteLine(GetDeletionDistance("frog", "dog")); // 3
        Console.WriteLine(GetDeletionDistance("some", "thing")); // 9
    }
}
