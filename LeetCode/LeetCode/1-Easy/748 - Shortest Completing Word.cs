using System.Collections.Generic;

// https://leetcode.com/problems/shortest-completing-word/
public partial class Solution
{
    public string ShortestCompletingWord(string licensePlate, string[] words)
    {
        var dict = new Dictionary<char, int>();
        for (int i = 0; i < licensePlate.Length; i++)
        {
            char cur = char.ToLower(licensePlate[i]);

            if (char.IsDigit(cur) || char.IsWhiteSpace(cur))
                continue;

            if (!dict.ContainsKey(cur))
                dict.Add(cur, 0);

            dict[cur]++;
        }

        string result = null;
        foreach (var word in words)
        {
            var dictCopy = new Dictionary<char, int>(dict);
            for (int i = 0; i < word.Length; i++)
            {
                char cur = char.ToLower(word[i]);
                if (dictCopy.ContainsKey(cur))
                {
                    dictCopy[cur]--;

                    if (dictCopy[cur] == 0)
                        dictCopy.Remove(cur);
                }
            }

            if (dictCopy.Count == 0 && (result == null || result.Length > word.Length))
                result = word;
        }

        return result;
    }
}
