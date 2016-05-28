using System;

namespace _HackerRankSln._Algorithms._02___Implementation
{
    public static class Library_Fine
    {
        public static void CalculateFine()
        {
            int d1, m1, y1, d2, m2, y2;
            GetInput(out d1, out m1, out y1, out d2, out m2, out y2);

            int fine = 0;

            if (y1 > y2)
            {
                fine = 10000;
            }
            else if (y1 == y2)
            {
                if (m1 > m2)
                {
                    fine = (m1 - m2) * 500;
                }
                else if (m1 == m2)
                {
                    if (d1 > d2)
                    {
                        fine = (d1 - d2) * 15;
                    }
                    // Else: Day is before, we don't assign fine
                }
                // Else: Month is before, we don't assign fine
            }
            // Else: Year is before, we don't assign fine

            Console.WriteLine(fine);
        }

        private static void GetInput(out int d1, out int m1, out int y1, out int d2, out int m2, out int y2)
        {
            string[] tokens_d1 = Console.ReadLine().Split(' ');
            d1 = Convert.ToInt32(tokens_d1[0]);
            m1 = Convert.ToInt32(tokens_d1[1]);
            y1 = Convert.ToInt32(tokens_d1[2]);
            string[] tokens_d2 = Console.ReadLine().Split(' ');
            d2 = Convert.ToInt32(tokens_d2[0]);
            m2 = Convert.ToInt32(tokens_d2[1]);
            y2 = Convert.ToInt32(tokens_d2[2]);
        }
    }

}