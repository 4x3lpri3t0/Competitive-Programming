using System.Collections.Generic;

// https://leetcode.com/problems/univalued-binary-tree/
public partial class Solution
{
    public bool IsUnivalTree(TreeNode root)
    {
        int value = root.val;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while (q.Count != 0)
        {
            var current = q.Dequeue();
            if (current.val != value)
                return false;
            if (current.left != null)
                q.Enqueue(current.left);
            if (current.right != null)
                q.Enqueue(current.right);
        }

        return true;
    }
}
