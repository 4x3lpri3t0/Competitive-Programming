using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _HackerRankSln._02___Implementation
{
    public static class Sherlock_and_Squares
    {
        public static void Sherlock()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, int.Parse);

                int max = a[1];
                int min = a[0];

                int squaresCount = (int)Math.Floor(Math.Sqrt(max)) - (int)Math.Ceiling(Math.Sqrt(min)) + 1;

                Console.WriteLine(squaresCount);
            }
        }
    }
}
