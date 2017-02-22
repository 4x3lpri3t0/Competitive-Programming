using System;
using System.Linq;

namespace CodeFights.Arcade.Intro.Level_2
{
    public class ShapeArea
    {
        public static void Main()
        {
            Console.WriteLine(shapeArea(1)); // 1
            Console.WriteLine(shapeArea(2)); // 5
            Console.WriteLine(shapeArea(3)); // 13
            Console.WriteLine(shapeArea(4)); // 25
        }

        private static int shapeArea(int n)
        {
            return n * n + (n - 1) * (n - 1);
        }
    }
}