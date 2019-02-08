// https://leetcode.com/problems/fibonacci-number/
public partial class Solution
{
    public int Fib(int N)
    {
        if (N == 0)
            return 0;

        int n1 = 0;
        int n2 = 1;
        for (int i = 2; i < N; i++)
        {
            int temp = n1 + n2;
            n1 = n2;
            n2 = temp;
        }

        return n1 + n2;
    }
}
