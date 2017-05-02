using System;

// TODO: Review
// https://www.hackerrank.com/challenges/encryption

public class Encryption
{
    public static void Main()
    {
        string text = Console.ReadLine();

        double sqrt = Math.Sqrt(text.Length);
        double rows = Math.Floor(sqrt);
        double column = Math.Ceiling(sqrt);

        while (rows * column < text.Length)
        {
            if (rows == column)
                column++;
            else
                rows++;
        }

        string newText = "";

        for (int i = 0; i < column; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                int index = (int)(j * column + i);
                if (index >= text.Length)
                    break;

                newText += text[index];
            }

            newText += " ";
        }

        Console.WriteLine(newText);
    }
}