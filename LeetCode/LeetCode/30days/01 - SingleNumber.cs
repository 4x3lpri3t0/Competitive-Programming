// https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/528/week-1/3283/
public partial class Solution
{
    public int SingleNumber(int[] nums)
    {
        int single = nums[0];
        
        for (int i = 1; i < nums.Length; i++)
            single = nums[i] ^ single;

        return single;
    }
}