using System;

namespace InterviewCake.Questions
{
    public class _10___StockPrice
    {
        public static int GetMaxProfit(int[] stocks)
        {
            // Greedily update minPrice and maxProfit
            int minPrice = stocks[0];
            int maxProfit = 0;

            for (int i = 1; i < stocks.Length; i++)
            {
                int yesterdayPrice = stocks[i - 1];
                int currentPrice = stocks[i];

                int potentialProfit = currentPrice - minPrice;

                // Update maxProfit if we can do better
                maxProfit = Math.Max(maxProfit, potentialProfit);

                // Update minPrice so it's always the lowest price we've seen so far
                minPrice = Math.Min(minPrice, currentPrice);
            }

            return maxProfit;
        }
    }
}
