using System;
using System.Collections.Generic;
using System.Linq;

// https://www.hackerrank.com/challenges/maximum-element

public static class Maximum_Element
{
    public static void _Main()
    {
        var stack = new Stack<long>();
        long max = long.MinValue;
        int T = Convert.ToInt32(Console.ReadLine());
        while (T-- != 0)
        {
            string input = Console.ReadLine();
            char option = input[0];
            if (option == '1')
            {
                long[] line = Array.ConvertAll(input.Split(' '), long.Parse);
                long n = line[1];
                stack.Push(n);
                if (n > max)
                {
                    max = n;
                }
            }
            else if (option == '2')
            {
                long deleted = stack.Pop();
                if (deleted == max)
                {
                    if (stack.Count > 0)
                    {
                        max = stack.Max();
                    }
                    else
                    {
                        max = long.MinValue;
                    }
                }
            }
            else
            {
                Console.WriteLine(max);
            }
        }
    }
}