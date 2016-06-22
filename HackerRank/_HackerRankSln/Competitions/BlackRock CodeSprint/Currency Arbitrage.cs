using System;
using System.Globalization;

namespace _HackerRankSln.Competitions.BlackRock_CodeSprint
{
    public static class Currency_Arbitrage
    {
        const double STARTING_CASH = 100000;

        public static void Main()
        {
            int T = Convert.ToInt32(Console.ReadLine());
            while (T-- > 0)
            {
                var currencies = GetInput();

                double money = STARTING_CASH;
                for (int i = 0; i < currencies.Length; i++)
                {
                    double conversionRate = currencies[i];
                    money /= conversionRate;
                }

                Console.WriteLine(money > STARTING_CASH ?
                    Math.Truncate(money - STARTING_CASH) : 0);
            }
        }

        private static double[] GetInput()
        {
            string[] input = Console.ReadLine().Split(' ');
            double[] currencies = new double[input.Length];
            for (int i = 0; i < currencies.Length; i++)
            {
                currencies[i] = double.Parse(input[i], CultureInfo.InvariantCulture);
            }
            return currencies;
        }
    }
}
