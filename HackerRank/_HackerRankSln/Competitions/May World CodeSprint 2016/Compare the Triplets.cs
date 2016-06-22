using System;

namespace _HackerRankSln.Competitions.May_World_CodeSprint_2016
{
    public static class Compare_the_Triplets
    {
        public static void Compare()
        {
            int[] tokens_a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] tokens_b = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int aScore = 0;
            int bScore = 0;

            for (int i = 0; i < tokens_a.Length; i++)
            {
                if (tokens_a[i] > tokens_b[i])
                    aScore++;
                else if (tokens_a[i] < tokens_b[i])
                    bScore++;
            }

            Console.WriteLine(aScore + " " + bScore);
        }
    }
}
