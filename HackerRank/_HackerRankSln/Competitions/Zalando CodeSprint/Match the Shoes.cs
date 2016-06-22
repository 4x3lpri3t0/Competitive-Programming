using System;
using System.Collections.Generic;
using System.Linq;

namespace _HackerRankSln.Competitions.Zalando_CodeSprint
{
    public static class Match_the_Shoes
    {
        public static void _Main()
        {
            var dict = new Dictionary<int, long>();
            long[] array = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            long K = array[0];
            long M = array[1];
            long N = array[2];

            // Initialize each element in the dict
            for (int i = 0; i < M; i++)
            {
                dict.Add(i, 0);
            }

            while (N-- != 0)
            {
                int idPurchased = Convert.ToInt32(Console.ReadLine());
                dict[idPurchased]++;
            }

            var orderedDict = dict.OrderByDescending(key => key.Value)
                                  .ThenBy(key => key.Key)
                                  .ToList();

            for (int i = 0; i < K; i++)
            {
                Console.WriteLine(orderedDict.ElementAt(i).Key);
            }
        }
    }
}
