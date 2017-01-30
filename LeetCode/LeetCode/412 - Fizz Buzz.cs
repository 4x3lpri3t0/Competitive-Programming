using System.Collections.Generic;

public partial class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        var list = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            string str = "";
            if (i % 3 != 0 && i % 5 != 0)
            {
                str = i.ToString();
            }
            if (i % 3 == 0)
            {
                str += "Fizz";
            }
            if (i % 5 == 0)
            {
                str += "Buzz";
            }

            list.Add(str);
        }

        return list;
    }
}