using System;
using System.Collections.Generic;
using System.Linq;

// https://codefights.com/arcade/intro/level-3/fzsCQGYbxaEcTr2bL

public class _allLongestStrings
{
    public static void Main()
    {
        var task = new _allLongestStrings();
        var result = task.allLongestStrings(new string[] { "aba", "aa", "ad", "vcd", "aba" });
        Console.WriteLine(string.Join(" ", result));
    }

    private string[] allLongestStrings(string[] inputArray)
    {
        int currentMaxLength = 0;
        var list = new List<string>();

        for (int i = 0; i < inputArray.Length; i++)
        {
            string cur = inputArray[i];
            int len = cur.Length;

            if (len < currentMaxLength)
            {
                continue;
            }
            else if (len > currentMaxLength)
            {
                currentMaxLength = len;
                list.Clear();
            }

            list.Add(cur); // == maxLength
        }

        return list.ToArray();
    }
}