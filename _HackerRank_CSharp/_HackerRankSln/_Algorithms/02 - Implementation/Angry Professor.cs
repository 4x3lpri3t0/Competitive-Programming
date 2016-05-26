using System;
using System.Linq;

namespace _HackerRankSln._Algorithms._02___Implementation
{
    public static class Angry_Professor
    {
        public static void PrintCancelledClasses()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);

                int onTimeStudents = a.Count(x => x <= 0);
                string isCancelled = onTimeStudents < k ? "YES" : "NO";
                Console.WriteLine(isCancelled);
            }
        }
    }
}
