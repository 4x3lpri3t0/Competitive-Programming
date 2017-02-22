using System;
using System.Linq;

namespace CodeFights.Arcade.Intro.Level_2
{
    public class AdjacentElementsProduct
    {
        public static void Main()
        {
            int[] test = { 3, 6, -2, -5, 7, 3 };
            int result = adjacentElementsProduct(test);
            Console.WriteLine(result);
        }

        private static int adjacentElementsProduct(int[] arr)
        {
            int max = int.MinValue;

            for (int i = 1; i < arr.Length; i++)
            {
                max = Math.Max(max, arr[i] * arr[i - 1]);
            }

            return max;
        }
    }
}