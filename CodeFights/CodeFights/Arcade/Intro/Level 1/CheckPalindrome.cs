using System;
using System.Linq;

// https://codefights.com/arcade/intro/level-1/s5PbmwxfECC52PWyQ

public class CheckPalindrome
{
    public static void Main()
    {
        Console.WriteLine(checkPalindrome("aabaa"));
        Console.WriteLine(checkPalindrome("abb"));
    }

    private static bool checkPalindrome(string str)
    {
        char[] strArray = str.ToCharArray();
        Array.Reverse(strArray);
        return str == new string(strArray);
    }
}