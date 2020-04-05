// https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/528/week-1/3287/
public partial class Solution
{
	public int MaxProfit(int[] prices)
	{
		int maxprofit = 0;

		for (int i = 1; i < prices.Length; i++)
		{
			if (prices[i] > prices[i - 1])
			{
				maxprofit += prices[i] - prices[i - 1];
			}
		}
		return maxprofit;
	}
}