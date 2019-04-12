// https://leetcode.com/problems/range-sum-query-immutable/
public class NumArray
{
    int[] sumArray;

    public NumArray(int[] nums)
    {
        sumArray = new int[nums.Length + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            sumArray[i + 1] = sumArray[i] + nums[i];
        }
    }

    public int SumRange(int i, int j)
    {
        return (sumArray[j + 1] - sumArray[i]);
    }
}
