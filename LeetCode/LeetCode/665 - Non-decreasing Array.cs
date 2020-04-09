// https://leetcode.com/problems/non-decreasing-array/
public partial class Solution
{
    public bool CheckPossibility(int[] numbers)
    {
        int changes = 0;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i + 1])
            {
                if (i > 0 && numbers[i - 1] > numbers[i + 1])
                {
                    numbers[i + 1] = numbers[i];
                    changes++;
                    continue;
                }

                numbers[i] = numbers[i + 1];
                changes++;
            }
        }
        return changes < 2;
    }
}