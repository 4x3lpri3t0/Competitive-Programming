using System;

// XOR: http://stackoverflow.com/a/41964276

namespace _HackerRankSln.Cracking_the_Coding_Interview.Techniques
{
    public class Bit_Manipulation___Lonely_Integer
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, int.Parse);

            int cum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                cum ^= a[i];
            }

            Console.WriteLine(cum);
        }
    }
}
