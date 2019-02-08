using System.Collections.Generic;

// https://leetcode.com/problems/search-in-a-binary-search-tree/
public partial class Solution
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while (q.Count > 0)
        {
            var node = q.Dequeue();
            if (node.val == val)
                return node;

            if (node.left != null && node.val > val)
                q.Enqueue(node.left);
            if (node.right != null && node.val < val)
                q.Enqueue(node.right);
        }

        return null;
    }
}
