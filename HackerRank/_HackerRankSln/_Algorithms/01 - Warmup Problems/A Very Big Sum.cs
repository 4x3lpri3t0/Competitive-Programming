using System;
using System.Linq;

namespace _HackerRankSln._Algorithms._01___Warmup_Problems
{
    public static class A_Very_Big_Sum
    {
        public static long VeryBigSum()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            long[] arr = Array.ConvertAll(arr_temp, long.Parse);

            return arr.Sum();
        }
    }
}
