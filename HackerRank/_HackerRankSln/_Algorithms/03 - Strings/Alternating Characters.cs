using System;

// https://www.hackerrank.com/challenges/alternating-characters

public static class Alternating_Characters
{
    public static void CountDeletions()
    {
        int T = Convert.ToInt32(Console.ReadLine());
        while (T-- != 0)
        {
            string str = Console.ReadLine();
            int count = 0;
            char prev = ' ';
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != prev)
                {
                    prev = str[i];
                }
                else
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}