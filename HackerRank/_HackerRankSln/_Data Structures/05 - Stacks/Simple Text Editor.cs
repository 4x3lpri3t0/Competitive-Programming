using System;
using System.Collections.Generic;

// https://www.hackerrank.com/challenges/simple-text-editor

public static class Simple_Text_Editor
{
    public static void Main()
    {
        string S = "";
        int Q = Convert.ToInt32(Console.ReadLine());
        var stack = new Stack<string>();
        while (Q-- != 0)
        {
            string[] inputArray = Console.ReadLine().Split(' ');
            int operation = Convert.ToInt32(inputArray[0]);

            // APPEND
            if (operation == 1)
            {
                stack.Push(S);
                S = Append(S, inputArray[1]);
            }
            // DELETE
            else if (operation == 2)
            {
                stack.Push(S);
                int k = Convert.ToInt32(inputArray[1]);
                S = Delete(S, k);
            }
            // PRINT
            else if (operation == 3)
            {
                int k = Convert.ToInt32(inputArray[1]) - 1;
                Print(S, k);
            }
            // UNDO
            else
            {
                S = Undo(S, stack);
            }
        }
    }

    private static string Append(string S, string W)
    {
        return string.Concat(S, W);
    }

    private static string Delete(string S, int k)
    {
        int startAt = S.Length - k;
        return S.Remove(startAt);
    }

    private static void Print(string S, int k)
    {
        Console.WriteLine(S[k]);
    }

    private static string Undo(string S, Stack<string> stack)
    {
        return stack.Pop();
    }
}