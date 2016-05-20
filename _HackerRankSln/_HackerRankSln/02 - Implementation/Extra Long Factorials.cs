using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _HackerRankSln._02___Implementation
{
    public static class Extra_Long_Factorials
    {
        public static void CalculateFactorial()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            BigInteger accumulator = 1;

            for (int i = 1; i <= num; i++)
            {
                accumulator *= i;
            }

            Console.WriteLine(accumulator);
        }
    }
}
