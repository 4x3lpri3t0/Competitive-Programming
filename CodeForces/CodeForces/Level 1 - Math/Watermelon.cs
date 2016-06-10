using System;

namespace CodeForces.Level_1___Math
{
    public static class Watermelon
    {
        public static void Main()
        {
            int w = Convert.ToInt32(Console.ReadLine());

            bool evenlyDividible = false;
            for (int i = 1; i < w; i++)
            {
                int boy1part = i;
                int boy2part = w - i;

                if (boy1part % 2 == 0 && boy2part % 2 == 0)
                    evenlyDividible = true;
            }

            Console.WriteLine(evenlyDividible ? "YES" : "NO");
        }
    }
}
