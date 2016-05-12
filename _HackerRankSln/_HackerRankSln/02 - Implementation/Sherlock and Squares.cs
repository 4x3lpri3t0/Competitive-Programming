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

                int squaresCount = 0;
                for (int i = a[0]; i <= a[1]; i++)
                {
                    double sqrRootResult = Math.Sqrt(i);

                    // Check if it's integer after sqrt operation
                    if ((sqrRootResult % 1) == 0)
                    {
                        squaresCount++;
                    }
                }

                Console.WriteLine(squaresCount);
            }
        }
    }
}
