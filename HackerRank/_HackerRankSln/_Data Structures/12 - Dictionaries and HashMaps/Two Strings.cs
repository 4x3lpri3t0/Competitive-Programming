// https://www.hackerrank.com/challenges/two-strings/problem
using System.Collections.Generic;

public static class Two_Strings
{
    public static string TwoStrings(string s1, string s2)
    {
        var characterSet = new HashSet<char>();
        foreach (char character in s1)
        {
            characterSet.Add(character);
        }

        foreach (char character in s2)
        {
            if (characterSet.Contains(character))
                return "YES";
        }

        return "NO";
    }
}