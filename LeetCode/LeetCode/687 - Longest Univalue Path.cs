// https://leetcode.com/problems/longest-univalue-path/
using System;

public partial class Solution
{
    public int max;
    public int LongestUnivaluePath(TreeNode root)
    {
        max = 0;

        if (root == null)
            return 0;

        LongestUni(root);
        return max;
    }

    private int LongestUni(TreeNode root)
    {
        int leftChildPathLength = 0;
        int rightChildPathLength = 0;

        if (root.left != null)
        {
            int left = LongestUni(root.left);
            if (root.left.val == root.val)
                leftChildPathLength = left + 1; // Add edge with top node
        }

        if (root.right != null)
        {
            int right = LongestUni(root.right);
            if (root.right.val == root.val)
                rightChildPathLength = right + 1; // Add edge with top node
        }

        // Update global max
        max = Math.Max(max, leftChildPathLength + rightChildPathLength);

        return Math.Max(leftChildPathLength, rightChildPathLength);
    }
}