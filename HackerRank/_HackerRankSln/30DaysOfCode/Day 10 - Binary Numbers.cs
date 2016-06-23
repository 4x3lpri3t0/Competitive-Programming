using System;

namespace _HackerRankSln._30DaysOfCode
{
    public static class Day_10___Binary_Numbers
    {
        public static void _Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Convert.ToString(n, 2);

            int max = 0;
            int current = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    current++;
                    if (current > max)
                    {
                        max = current;
                    }
                }
                else
                {
                    current = 0;
                }
            }

            Console.WriteLine(max);
        }
    }
}
