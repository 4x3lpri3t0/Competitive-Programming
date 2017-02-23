using System;

namespace _HackerRankSln.Cracking_the_Coding_Interview.Techniques
{
    public class Recursion___Davis__Staircase
    {
        public static void Main()
        {
            int s = Convert.ToInt32(Console.ReadLine());
            int no_of_ways = 0;
            for (int a0 = 0; a0 < s; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] memorization_array = new int[n + 1];
                memorization_array[0] = 1;
                Console.WriteLine(WaysToGo(n, no_of_ways, memorization_array));
                no_of_ways = 0;
            }
        }

        static int WaysToGo(int n, int count, int[] mem_array)
        {
            if (n == 0) return 1;
            else if (n < 0) return 0;
            else if (n >= 0 && mem_array[n] != 0) return mem_array[n];
            else
            {
                count = WaysToGo(n - 1, count, mem_array) + 
                        WaysToGo(n - 2, count, mem_array) +
                        WaysToGo(n - 3, count, mem_array);

                mem_array[n] = count;

                return count;
            }
        }
    }
}