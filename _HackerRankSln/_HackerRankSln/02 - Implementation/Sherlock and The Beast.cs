using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Find the largest Decent Number having NN digits.

////A Decent Number has the following properties:

////    Its digits can only be 3's and/or 5's.
////    The number of 3's it contains is divisible by 5.
////    The number of 5's it contains is divisible by 3.
////    If there are more than one such number, we pick the largest one.


//// Input Format

////The first line is an integer, TT, denoting the number of test cases.

////The TT subsequent lines each contain an integer, NN, detailing the number of digits in the number.

//// Output Format

////Print the largest Decent Number having NN digits; if no such number exists, tell Sherlock by printing -1.

namespace _HackerRankSln._02___Implementation
{
    public static class Sherlock_and_The_Beast
    {
        public static void CalculateLinearDiophantineEquation()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int z = n;
                while (z % 3 != 0 && z > 0)
                {
                    z -= 5;
                }

                if (z < 0)
                {
                    Console.WriteLine("-1");
                }
                else {
                    Console.WriteLine(new string('5', z) + new string('3', (n - z)));
                }
            }
        }
    }
}
