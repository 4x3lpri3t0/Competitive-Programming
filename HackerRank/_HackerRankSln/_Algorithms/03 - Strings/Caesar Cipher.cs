using System;

// https://www.hackerrank.com/challenges/caesar-cipher-1

public static class Caesar_Cipher
{
    private const int MINUS_UPPER_BOUND = 122;
    private const int MINUS_LOWER_BOUND = 97;
    private const int MAYUS_UPPER_BOUND = 90;
    private const int MAYUS_LOWER_BOUND = 65;

    public static void Encrypt()
    {
        int n, k;
        string s;
        GetInput(out n, out k, out s);

        string encryptedString = "";
        for (int i = 0; i < n; i++)
        {
            int value = s[i];
            MantainIfSymbol(ref encryptedString, value);
            EncryptChar(k, ref encryptedString, ref value, MINUS_LOWER_BOUND, MINUS_UPPER_BOUND);
            EncryptChar(k, ref encryptedString, ref value, MAYUS_LOWER_BOUND, MAYUS_UPPER_BOUND);
        }

        Console.WriteLine(encryptedString);
    }

    private static void EncryptChar(int rotation, ref string encryptedString, ref int value, int lowerBound, int upperBound)
    {
        if (value >= lowerBound && value <= upperBound)
        {
            int pureValue = value - lowerBound;
            int cleanValue = (pureValue + rotation) % 26;

            int newValue = lowerBound + cleanValue;

            char c = (char)newValue;
            encryptedString += c;
        }
    }

    private static string MantainIfSymbol(ref string encryptedString, int value)
    {
        // Other symbols should stay the same
        if (value < MAYUS_LOWER_BOUND || value > MINUS_UPPER_BOUND
            || (value > MAYUS_UPPER_BOUND && value < MINUS_LOWER_BOUND))
        {
            encryptedString += (char)value;
        }

        return encryptedString;
    }

    private static void GetInput(out int n, out int k, out string s)
    {
        n = Convert.ToInt32(Console.ReadLine());
        s = Console.ReadLine();
        k = Convert.ToInt32(Console.ReadLine());
    }
}