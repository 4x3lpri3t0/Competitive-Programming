using System.Collections.Generic;

// https://leetcode.com/problems/find-and-replace-pattern/
public partial class Solution
{
    public IList<string> FindAndReplacePattern(string[] words, string pattern)
    {
        var result = new List<string>();
        foreach (var word in words)
        {
            if (word.Length != pattern.Length)
                continue;

            var dict = new Dictionary<char, char>();
            bool valid = true;
            for (int i = 0; i < word.Length; i++)
            {
                if (!dict.ContainsKey(pattern[i]))
                {
                    // Value was there but for other pattern
                    if (dict.ContainsValue(word[i])) {
                        valid = false;
                        break;
                    }

                    dict[pattern[i]] = word[i];
                } else // Contains key
                {
                    if (dict[pattern[i]] != word[i])
                    {
                        valid = false;
                        break;
                    }
                }
            }

            if (valid)
                result.Add(word);
        }

        return result;
    }
}
