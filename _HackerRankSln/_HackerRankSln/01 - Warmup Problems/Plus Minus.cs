using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _HackerRankSln._01___Warmup_Problems
{
    public static class Plus_Minus
    {
        public static void PrintFractions()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            int positiveCount = arr.Count(x => x > 0);
            decimal positiveFraction = Decimal.Divide(positiveCount, arr.Length);
            Console.WriteLine(positiveFraction);

            int negativeCount = arr.Count(x => x < 0);
            decimal negativeFraction = Decimal.Divide(negativeCount, arr.Length);
            Console.WriteLine(negativeFraction);

            int zeroCount = arr.Count(x => x == 0);
            decimal zeroFraction = Decimal.Divide(zeroCount, arr.Length);
            Console.WriteLine(zeroFraction);
        }
    }
}
