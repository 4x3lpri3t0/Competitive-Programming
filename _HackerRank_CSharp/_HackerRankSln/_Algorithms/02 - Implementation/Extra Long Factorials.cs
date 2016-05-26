using System;
using System.Numerics;

namespace _HackerRankSln._Algorithms._02___Implementation
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
