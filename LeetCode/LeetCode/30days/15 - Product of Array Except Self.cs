// https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/530/week-3/3300/
public partial class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int length = nums.Length;
        var products = new int[length];

        // -->
        int product = 1;
        products[0] = 1;
        for (int i = 1; i < length; i++)
        {
            product *= nums[i - 1];
            products[i] = product;
        }

        // <--
        product = 1;
        for (int i = length - 2; i >= 0; i--)
        {
            product *= nums[i + 1];
            products[i] *= product;
        }

        return products;
    }
}