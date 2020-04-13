using System.Collections.Generic;
using System.Linq;

// https://leetcode.com/problems/uncommon-words-from-two-sentences/
public partial class Solution
{
	public string[] UncommonFromSentences(string A, string B)
	{
		var listA = new List<string>(A.Split(' '));
		var listB = new List<string>(B.Split(' '));

		return RemoveRepeatedWords(listA, listB).ToArray();
	}

	private HashSet<string> RemoveRepeatedWords(List<string> listA, List<string> listB)
	{
		var repeatedWords = new HashSet<string>();
		var words = new HashSet<string>();

		var list = listA.Concat(listB);

<<<<<<< HEAD
		foreach (var word in list)
		{
			if (!repeatedWords.Contains(word))
			{
				if (words.Contains(word))
				{
					words.Remove(word);
					repeatedWords.Add(word);
				}
				else
				{
					words.Add(word);
				}
			}
		}
=======
        foreach (var word in list)
        {
            if (repeatedWords.Contains(word))
                words.Remove(word);
            else
                words.Add(word);

            repeatedWords.Add(word);
        }
>>>>>>> 3b1b9e78cd7fadc333e7dd3e75f37131d5b9dfae

		return words;
	}
}
