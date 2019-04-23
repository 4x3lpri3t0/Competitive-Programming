// https://leetcode.com/problems/longest-univalue-path/
public partial class Solution
{
    public static int max = 0;
    public int LongestUnivaluePath(TreeNode root)
    {
        LongestUni(root);

        return max; // Current
    }

    private int LongestUni(TreeNode root)
    {
        int sum = 0;
        if (root.left != null)
        {
            int left = LongestUnivaluePath(root.left);
            sum = root.left.val == root.val ?  : 1;

        }
        if (root.right != null)
        {
            sum = root.right.val == root.val ? LongestUnivaluePath(root.right) : 0;

        }

        return sum;
    }
}