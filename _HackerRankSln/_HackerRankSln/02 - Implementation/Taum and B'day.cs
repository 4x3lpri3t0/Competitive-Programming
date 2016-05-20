using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _HackerRankSln._02___Implementation
{
    public static class Taum_and_B_day
    {
        public static void GiftCalculator()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_b = Console.ReadLine().Split(' ');
                long b = Convert.ToInt64(tokens_b[0]);
                long w = Convert.ToInt64(tokens_b[1]);
                string[] tokens_x = Console.ReadLine().Split(' ');
                long x = Convert.ToInt64(tokens_x[0]);
                long y = Convert.ToInt64(tokens_x[1]);
                long z = Convert.ToInt64(tokens_x[2]);

                // TODO ...
            }
        }
    }
}
