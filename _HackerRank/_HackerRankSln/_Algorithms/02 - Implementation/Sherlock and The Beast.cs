using System;

namespace _HackerRankSln._Algorithms._02___Implementation
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
