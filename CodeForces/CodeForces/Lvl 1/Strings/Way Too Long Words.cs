using System;

public static class Way_Too_Long_Words
{
    public static void Main()
    {
        int T = Convert.ToInt32(Console.ReadLine());
        while (T-- > 0)
        {
            string input = Console.ReadLine();
            var length = input.Length;
            if (length > 10)
            {
                input = input[0] + (length - 2).ToString() + input[input.Length - 1];
            }

            Console.WriteLine(input);
        }
    }
}