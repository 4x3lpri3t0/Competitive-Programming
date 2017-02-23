using System;
using System.Collections.Generic;

// Using Greedy instead of Recursion

namespace _HackerRankSln.Cracking_the_Coding_Interview.Techniques
{
    public class Recursion___Fibonacci_Numbers
    {
        private static List<int> fibs = new List<int>();

        static Recursion___Fibonacci_Numbers()
        {
            fibs.Add(0);
            fibs.Add(1);

            for (int i = 2; i <= 42; i++)
            {
                fibs.Add(fibs[i - 1] + fibs[i - 2]);
            }
        }

        private static int Fibonacci(int n)
        {
            return fibs[n];
        }

        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
        }
    }
}
