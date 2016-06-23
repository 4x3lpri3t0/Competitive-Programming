using System;
using System.Linq;

namespace _HackerRankSln._Data_Structures._01___Arrays
{
    public static class Arrays___DS
    {
        public static void PrintReversedElements()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, int.Parse);

            string reversed = string.Join(" ", arr.Reverse());

            Console.WriteLine(reversed);
        }
    }
}
