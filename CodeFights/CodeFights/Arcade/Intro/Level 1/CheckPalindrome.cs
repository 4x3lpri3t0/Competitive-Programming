using System;
using System.Linq;

namespace CodeFights.Arcade.Intro
{
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
}