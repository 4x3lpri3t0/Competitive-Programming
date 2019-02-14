// https://leetcode.com/problems/non-decreasing-array/
public partial class Solution
{
    public bool CheckPossibility(int[] nums)
    {
        var flipped = false;
        var length = nums.Length;
        var lengthMinusOne = length - 1;

        for (int i = 1; i < length; i++)
        {
            if (nums[i - 1] > nums[i])
            {
                if (flipped)
                    return false;

                if (i < lengthMinusOne && nums[i - 1] > nums[i + 1])
                {
                    nums[i - 1] = nums[i];
                    if (i - 2 >= 0 && nums[i - 2] > nums[i - 1])
                    {
                        return false;
                    }
                }
                else
                {
                    nums[i] = nums[i - 1];
                }

                flipped = true;
            }
        }

        return true;
    }
}