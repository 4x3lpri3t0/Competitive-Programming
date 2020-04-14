// https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/529/week-2/3291/
using System.Collections.Generic;

public partial class Solution
{
	public bool BackspaceCompare(string S, string T)
	{
		string finalS = GetFinalString(S);
		string finalT = GetFinalString(T);

		return finalS == finalT;
	}

	private static string GetFinalString(string str)
	{
		var s = new Stack<char>();
		foreach (char c in str)
		{
			if (c != '#')
				s.Push(c);
			else if (s.Count > 0)
				s.Pop();
		}

		return new string(s.ToArray());
	}
}