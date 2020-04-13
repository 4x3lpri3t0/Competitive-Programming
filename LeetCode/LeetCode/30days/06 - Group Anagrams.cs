// https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/528/week-1/3288/
using System;
using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var anagraMap = new Dictionary<string, List<string>>();
        foreach (var str in strs)
        {
            // Sort
            char[] charArray = str.ToArray();
            Array.Sort(charArray);
            string key = new string(charArray);

            // Store
            if (!anagraMap.ContainsKey(key))
                anagraMap.Add(key, new List<string>());
            anagraMap[key].Add(str);
        }

        // Return
        var result = new List<IList<string>>();
        foreach (var kv in anagraMap)
            result.Add(kv.Value);

        return result;
    }
}