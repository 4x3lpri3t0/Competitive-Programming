using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //PrintList(new Solution().FizzBuzz(15));
        //Print(new Solution().ReverseString("hello"));
        // MaxIncreaseKeepingSkyline
    }

    private static void Print<T>(T data)
    {
        Console.WriteLine(data);
    }

    private static void PrintList<T>(IList<T> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
