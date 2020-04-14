// https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/529/week-2/3293/

using System;
/**
* Definition for a binary tree node.
* public class TreeNode {
*     public int val;
*     public TreeNode left;
*     public TreeNode right;
*     public TreeNode(int x) { val = x; }
* }
*/
public partial class Solution
{
    int diameter;
    public int DiameterOfBinaryTree(TreeNode root)
    {
        diameter = 0;
        CalculateHeight(root);
        return diameter;
    }

    private int CalculateHeight(TreeNode root)
    {
        if (root == null)
            return 0;
        int leftHeight = CalculateHeight(root.left);
        int rightHeight = CalculateHeight(root.right);
        diameter = Math.Max(diameter, leftHeight + rightHeight);

        return Math.Max(leftHeight, rightHeight) + 1;
    }
}