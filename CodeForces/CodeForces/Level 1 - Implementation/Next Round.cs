using System;
using System.Linq;

namespace CodeForces.Level_1___Implementation
{
    public static class Next_Round
    {
        public static void Main()
        {
            int[] inputRow = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int k = inputRow[1];
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int kValue = a[k - 1];
            int passing = a.Where(x => x >= kValue && x != 0)
                           .Count();

            Console.WriteLine(passing);
        }
    }
}
