using System;
using System.Linq;

// https://codefights.com/arcade/intro/level-1/egbueTZRRL5Mm4TXN

public class CenturyFromYear
{
    public static void Main()
    {
        int test1 = 1905;
        int result = centuryFromYear(test1);
        Console.WriteLine(result);

        int test2 = 2000;
        result = centuryFromYear(test2);
        Console.WriteLine(result);
    }

    private static int centuryFromYear(int year)
    {
        return --year / 100 + 1;
    }
}