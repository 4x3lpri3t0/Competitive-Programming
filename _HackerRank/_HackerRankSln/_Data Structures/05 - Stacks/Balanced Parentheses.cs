using System;
using System.Collections.Generic;

class Balanced_Parentheses
{
    public static void _Main()
    {
        var T = int.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            var line = Console.ReadLine();
            bool isValid = IsValid(line);
            Console.WriteLine(isValid ? "YES" : "NO"); 
        }
    }

    private static bool IsValid(string line)
    {
        var st = new Stack<char>();
        foreach (var c in line)
        {
            if (c == '{' || c == '[' || c == '(')
            {
                st.Push(c);
            }
            else
            {
                if (st.Count == 0)
                {
                    return false;
                }
                var prev = st.Pop();
                if (prev == '{' && c != '}')
                {
                    return false;
                }
                if (prev == '[' && c != ']')
                {
                    return false;
                }

                if (prev == '(' && c != ')')
                {
                    return false;
                }
            }
        }

        if (st.Count == 0)
            return true;
        else
            return false;
    }
}