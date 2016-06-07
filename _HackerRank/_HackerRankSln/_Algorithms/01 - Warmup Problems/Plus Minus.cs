using System;
using System.Linq;

namespace _HackerRankSln._Algorithms._01___Warmup_Problems
{
    public static class Plus_Minus
    {
        public static void PrintFractions()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, int.Parse);

            int positiveCount = arr.Count(x => x > 0);
            decimal positiveFraction = decimal.Divide(positiveCount, arr.Length);
            Console.WriteLine(positiveFraction);

            int negativeCount = arr.Count(x => x < 0);
            decimal negativeFraction = decimal.Divide(negativeCount, arr.Length);
            Console.WriteLine(negativeFraction);

            int zeroCount = arr.Count(x => x == 0);
            decimal zeroFraction = decimal.Divide(zeroCount, arr.Length);
            Console.WriteLine(zeroFraction);
        }
    }
}
