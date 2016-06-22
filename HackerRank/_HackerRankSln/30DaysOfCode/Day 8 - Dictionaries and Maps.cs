using System;
using System.Collections.Generic;

namespace _HackerRankSln._30DaysOfCode
{
    public static class Day_8___Dictionaries_and_Maps
    {
        public static void _Main()
        {
            int T1 = Convert.ToInt32(Console.ReadLine());
            int T2 = T1;
            var dic = new Dictionary<string, string>();
            while (T1-- != 0)
            {
                string[] line = Console.ReadLine().Split(' ');
                string name = line[0];
                string phone = line[1];

                dic.Add(name, phone);
            }
            while (T2-- != 0)
            {
                string queryName = Console.ReadLine();
                string value;
                var exists = dic.TryGetValue(queryName, out value);
                if (exists)
                {
                    Console.WriteLine(queryName + "=" + value);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
