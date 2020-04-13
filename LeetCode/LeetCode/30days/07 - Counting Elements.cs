// https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/528/week-1/3289/
using System.Linq;

public partial class Solution
{
    public int CountElements(int[] arr)
    {
        arr = arr.OrderBy(x => x).ToArray();

        // Always consider the previous one as counted
        int sameCounter = 1;
        int total = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1] + 1)
            {
                total += sameCounter;
                sameCounter = 1;
            }
            else if (arr[i] == arr[i - 1])
            {
                sameCounter++;
            }
            else
                sameCounter = 1;
        }

        return total;
    }
}