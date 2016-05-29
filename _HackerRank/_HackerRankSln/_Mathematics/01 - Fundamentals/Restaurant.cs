using System;

namespace _HackerRankSln._Mathematics._01___Fundamentals
{
    public static class Restaurant
    {
        // Total number of square of maximum size will be
        // (l/gcd(l, b))*(b/gcd(l, b))
        // Alter: (a*b)/(gcd(a,b)*gcd(a,b))
        // https://en.wikipedia.org/wiki/Greatest_common_divisor

        public static void gcdSquares()
        {
            int T = Convert.ToInt32(Console.ReadLine());
            while (T-- != 0)
            {
                string[] arrTemp = Console.ReadLine().Split(' ');
                int[] arrInt = Array.ConvertAll(arrTemp, int.Parse);
                int l = arrInt[0];
                int b = arrInt[1];

                int gCommonDivisor = gcd(l, b);
                int squares = (l / gCommonDivisor) * (b / gCommonDivisor);
                Console.WriteLine(squares);
            }
        }

        private static int gcd(int a, int b)
        {
            int t;

            while (b != 0)
            {
                t = b;
                b = a % t;
                a = t;
            }

            return a;
        }
    }
}
