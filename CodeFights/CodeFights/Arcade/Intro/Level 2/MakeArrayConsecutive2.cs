using System;
using System.Linq;

namespace CodeFights.Arcade.Intro.Level_2
{
    public class MakeArrayConsecutive2
    {
        public static void Main()
        {
            Console.WriteLine(makeArrayConsecutive2(new int[] { 6, 2, 3, 8 }));
        }

        private static int makeArrayConsecutive2(int[] statues)
        {
            int min = statues.Min();
            int max = statues.Max();

            return max - min - statues.Length + 1;
        }
    }
}