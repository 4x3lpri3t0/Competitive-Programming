using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _HackerRankSln.Problems
{
    public static class A_Very_Big_Sum
    {
        public static Int64 VeryBigSum()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            Int64[] arr = Array.ConvertAll(arr_temp, Int64.Parse);

            return arr.Sum();
        }
    }
}
