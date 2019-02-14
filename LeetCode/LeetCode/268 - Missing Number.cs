// https://leetcode.com/problems/missing-number/
public partial class Solution
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int total = (n * (n + 1)) / 2;
        for (int i = 0; i < nums.Length; i++)
        {
            total -= nums[i];
        }

        return total;
    }
}
