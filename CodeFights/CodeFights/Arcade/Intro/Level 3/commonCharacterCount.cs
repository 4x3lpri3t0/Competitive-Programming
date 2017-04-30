using System;
using System.Collections.Generic;
using System.Linq;

public class _commonCharacterCount
{
    public static void Main()
    {
        var task = new _commonCharacterCount();
        string s1 = "aabcc";
        string s2 = "adcaa";
        Console.WriteLine(task.commonCharacterCount(s1, s2));
    }

    private int commonCharacterCount(string s1, string s2)
    {
        var dict = new Dictionary<char, int>();

        for (int i = 0; i < s1.Length; i++)
        {
            char cur = s1[i];
            if (!dict.ContainsKey(cur))
            {
                dict.Add(cur, 1);
            }
            else
            {
                dict[cur]++;
            }
        }

        int count = 0;
        for (int i = 0; i < s2.Length; i++)
        {
            char cur = s2[i];
            if (dict.ContainsKey(cur) && dict[cur] > 0)
            {
                count++;
                dict[cur]--;
            }
        }

        return count;
    }
}