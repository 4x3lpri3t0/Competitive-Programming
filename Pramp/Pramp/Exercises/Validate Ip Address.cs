using System;

// https://www.pramp.com/challenge/Q5G1jZ1OWdtZ3GbAGpNE
public partial class Solution
{
    public static void ValidateIpAddress()
    {
        string ip = "192.168.0.1";
        Console.WriteLine(IsValidIpAddress(ip));

        ip = "1.1.1.oops";
        Console.WriteLine(IsValidIpAddress(ip));

        ip = "1.1.1.12312";
        Console.WriteLine(IsValidIpAddress(ip));
    }

    static bool IsValidIpAddress(string str)
    {
        // Contains exactly 3 dots
        if (!HasExactlyThreeDotsAndOnlyDigits(str))
            return false;

        string[] segments = str.Split('.');
        foreach (string segment in segments)
        {
            // Get substring until next dot (function)
            int number = int.Parse(segment);

            // Validate ranges
            if (!IsNumberBetweenRanges(number))
                return false;
        }

        return true;
    }

    static bool HasExactlyThreeDotsAndOnlyDigits(string str)
    {
        int dotCount = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '.')
                dotCount++;
            else if (!char.IsDigit(str[i])) // , ! ? & a c b
                return false;
        }

        return dotCount == 3;
    }

    static bool IsNumberBetweenRanges(int number)
    {
        if (number < 0 || number > 255) // not between ranges
            return false;
        return true;
    }
}
