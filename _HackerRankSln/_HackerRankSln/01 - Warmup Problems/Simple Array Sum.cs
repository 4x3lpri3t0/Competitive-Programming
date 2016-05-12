using System;
using System.Linq;

namespace _HackerRankSln._01___Warmup_Problems
{
    public static class Simple_Array_Sum
    {
        public static int ArraySum()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, int.Parse);

            return arr.Sum();
        }
    }
}
