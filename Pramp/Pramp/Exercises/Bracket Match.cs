// https://www.pramp.com/challenge/xJZA01AxdlfpM2vZ2Wwa
partial class Solution
{
    public static int BracketMatch(string text)
    {
        if (text == null || text.Length == 0) 
            return 0;

        int length = text.Length;
        var openBracket = 0;
        var misMatch = 0;

        foreach (var item in text)
        {
            bool isOpen = item == '(';
            if (isOpen)
            {
                openBracket++;
            }
            else
            {
                if (openBracket > 0)
                    openBracket--;
                else
                    misMatch++;
            }
        }

        return openBracket + misMatch;
    }
}