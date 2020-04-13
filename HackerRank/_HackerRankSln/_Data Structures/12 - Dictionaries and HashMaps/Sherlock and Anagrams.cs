// https://www.hackerrank.com/challenges/two-strings/problem
using System;
using System.Collections.Generic;

public static class Sherlock_and_Anagrams
{
	static int SherlockAndAnagrams(string s)
	{
		var dic = new Dictionary<string, int>();
		var count = 0;

		foreach (var substring in GetSubstring(s))
		{
			Console.WriteLine(substring);

			if (dic.ContainsKey(substring))
			{
				var value = dic[substring];
				count += value;

				dic[substring] = value + 1;
			}
			else
			{
				dic.Add(substring, 1);
			}
		}

		return count;
	}

	static IEnumerable<string> GetSubstring(string s)
	{
		for (var i = 0; i < s.Length; i++)
		{
			for (var j = 1; j <= s.Length - i; j++)
			{
				var substring = s.Substring(i, j);
				var chars = substring.ToCharArray();
				Array.Sort(chars);

				yield return new string(chars);
			}
		}
	}
}