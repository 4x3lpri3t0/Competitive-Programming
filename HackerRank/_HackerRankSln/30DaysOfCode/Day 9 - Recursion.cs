using System;

namespace _HackerRankSln._30DaysOfCode
{
    public static class Day_9___Recursion
    {
        public static void _Main()
        {
            long num = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(Factorial(num));
        }

        private static long Factorial(long n)
        {
            if (n == 1)
                return n;

            return n * Factorial(n - 1);
        }
    }
}
