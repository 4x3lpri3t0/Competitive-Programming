using System;

namespace _HackerRankSln._Algorithms._09___Bit_Manipulation
{
    public static class Lonely_Integer
    {
        /*
        a^a = 0
        a^0 = a
        So if you have an element repeated 2n times, it's xor is 0.
        And the lonely element remains as it is.
        */
        public static void Main()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int xor = 0;
            for (int i = 0; i < A.Length; i++)
            {
                // a ^ x ^ a = x
                xor ^= A[i];
            }

            Console.WriteLine(xor);
        }
    }
}
