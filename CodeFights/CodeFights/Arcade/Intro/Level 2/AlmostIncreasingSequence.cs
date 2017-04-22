using System;
using System.Linq;

namespace CodeFights.Arcade.Intro.Level_2
{
    public class AlmostIncreasingSequence
    {
        public static void Main()
        {
            //Console.WriteLine(almostIncreasingSequence(new int[] { 1, 3, 2, 1 }));
            //Console.WriteLine(almostIncreasingSequence(new int[] { 4, 2, 3, 5 }));
            Console.WriteLine(almostIncreasingSequence(new int[] { 1, 2, 1, 2 }));
        }

        private static bool almostIncreasingSequence(int[] sequence)
        {
            if (sequence.Length == 2) { return true; }
            int countOne = 0;
            int countTwo = 0;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] >= sequence[i + 1])
                {
                    countOne++;
                }
                if (i != 0)
                {
                    if (sequence[i - 1] >= sequence[i + 1])
                    {
                        countTwo++;
                    }
                }
            }

            if (countOne == 1 && countTwo <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}