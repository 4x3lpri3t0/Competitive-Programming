using System;

namespace _HackerRankSln.Cracking_the_Coding_Interview.Techniques
{
    public class Time_Complexity___Primality
    {
        static bool IsPrime(int n)
        {
            if (n == 2) return true;
            if (n == 1 || (n & 1) == 0) return false; // Is even?

            int sqrt = (int)Math.Floor(Math.Sqrt(n));
            for (int i = 3; i <= sqrt; i += 2)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        public static void Main()
        {
            int p = int.Parse(Console.ReadLine());
            while (p-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(IsPrime(n) ? "Prime" : "Not prime");
            }
        }
    }
}