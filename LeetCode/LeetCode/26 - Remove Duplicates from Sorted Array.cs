// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
public partial class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int uniqueIdx = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                continue;
            }

            uniqueIdx++;
            nums[uniqueIdx] = nums[i];
        }

        return uniqueIdx + 1;
    }
}