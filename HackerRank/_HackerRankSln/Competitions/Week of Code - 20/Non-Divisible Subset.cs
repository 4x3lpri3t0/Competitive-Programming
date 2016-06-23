using System;
using System.Linq;

namespace _HackerRankSln.Competitions.Week_of_Code___20
{
    public class Non_Divisible_Subset
    {
        public static void _Main()
        {
            long n;
            int k;
            long[] arrLong;
            Input(out n, out k, out arrLong);

            // Load collisions count for each n in arrLong
            var collisionCountByIndex = new long[n];
            bool setIsClear = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == i || i == -1)
                        continue;

                    if ((arrLong[i] + arrLong[j]) % k == 0)
                    {
                        collisionCountByIndex[i]++;
                        setIsClear = false;
                    }
                }
            }



            // Iterate -> Get index with more collisions
            long worstIndx = collisionCountByIndex.Max();
            //         -> Set -1 to n with most collisions
            collisionCountByIndex[worstIndx] = -1;

            //         -> Reevaluate
            //         -> If all n now have 0 collisions -> save number and display
        }

        private static void Input(out long n, out int k, out long[] arrLong)
        {
            string[] arrTemp = Console.ReadLine().Split(' ');
            long[] arrLongTemp = Array.ConvertAll(arrTemp, long.Parse);
            n = arrLongTemp[0];
            k = (int)arrLongTemp[1];
            arrTemp = Console.ReadLine().Split(' ');
            arrLong = Array.ConvertAll(arrTemp, long.Parse);
        }
    }
}
