public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

// https://leetcode.com/problems/range-sum-of-bst/
public partial class Solution
{
    public int RangeSumBST(TreeNode root, int L, int R)
    {
        int childrenVal = 0;

        // Recurse through L
        if (root.left != null)
        {
            childrenVal += RangeSumBST(root.left, L, R);
        }

        // Same for R
        if (root.right != null)
        {
            childrenVal += RangeSumBST(root.right, L, R);
        }

        return (root.val >= L && root.val <= R ? root.val : 0) + childrenVal;
    }
}
