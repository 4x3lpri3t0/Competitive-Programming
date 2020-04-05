// https://leetcode.com/contest/biweekly-contest-23/problems/construct-k-palindrome-strings/
public partial class Solution
{
	// There can only be zero or one odd per palindrome...
	public bool CanConstruct(string s, int k)
	{
		int[] freq = new int[26];

		for (int i = 0; i < s.Length; i++)
		{
			int cur = s[i] - 'a';
			freq[cur]++;
		}

		// Count odds, if odds > k, false
		int oddCount = 0;
		for (int i = 0; i < freq.Length; i++)
		{
			if (freq[i] % 2 != 0)
				oddCount++;
		}

		if (oddCount > k)
			return false;

		if (s.Length < k)
			return false;

		return true;
	}
}