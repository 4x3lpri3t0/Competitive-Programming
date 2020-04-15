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
    static int GetDeletionDistance(string s1, string s2)
    {
        if (string.IsNullOrEmpty(s1))
            return s2.Length;
        if (string.IsNullOrEmpty(s2))
            return s1.Length;

        // Need DP matrix?
        int[][] dp = new int[s1.Length + 1][];
        for (int i = 0; i < s2.Length; i++)
        {
            dp[i] = new int[s2.Length];
        }

        // TODO

        return 0;
    }

    public static void DeletionDistance()
    {
        Console.WriteLine(GetDeletionDistance("frog", "dog"));
        Console.WriteLine(GetDeletionDistance("some", "thing"));
    }
}

// hate
// atenas