using System.Collections.Generic;

// https://leetcode.com/problems/range-sum-of-bst/
public partial class Solution
{
	public int RangeSumBST(TreeNode root, int L, int R)
	{
		int childrenVal = 0;

		// Recurse through left child
		if (root.left != null)
			childrenVal += RangeSumBST(root.left, L, R);

		// Recurse through right child
		if (root.right != null)
			childrenVal += RangeSumBST(root.right, L, R);

		return (root.val >= L && root.val <= R ? root.val : 0) + childrenVal;
	}

	public int RangeSumBST_Alt(TreeNode root, int L, int R)
	{
		int childrenVal = 0;

		var q = new Queue<TreeNode>();
		q.Enqueue(root);
		while (q.Count > 0)
		{
			var node = q.Dequeue();
			if (node.val >= L && node.val <= R)
				childrenVal += node.val;
			if (node.left != null)
				q.Enqueue(node.left);
			if (node.right != null)
				q.Enqueue(node.right);
		}

		return childrenVal;
	}
}
