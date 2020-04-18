// 
using System.Collections.Generic;

public partial class Solution
{
    public int FindMinFibonacciNumbers(int k)
    {
        // Put em on a stak, and pop
        var stack = new Stack<int>();
        int a = 0;
        int b = 1;
        while (b <= k)
        {
            stack.Push(b);

            int temp = a;
            a = b;
            b += temp;
        }

        // Then while k > 0, substract and add one
        int fibsUsed = 0;
        while (k > 0)
        {
            int num = stack.Pop();
            if (num > k)
                continue;
            k -= num;
            fibsUsed++;
        }

        return fibsUsed;
    }
}