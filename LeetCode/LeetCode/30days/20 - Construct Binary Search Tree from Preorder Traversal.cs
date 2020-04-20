// https://leetcode.com/explore/challenge/card/30-day-leetcoding-challenge/530/week-3/3305/
using System.Collections.Generic;

public partial class Solution
{
    public TreeNode BstFromPreorder(int[] preorder)
    {
        return PreorderTraversal(preorder, new List<int>(preorder));
    }

    private static TreeNode PreorderTraversal(int[] preorder, IList<int> numbers)
    {
        if (numbers == null || numbers.Count == 0)
        {
            return null;
        }

        var rootValue = numbers[0];

        var root = new TreeNode(rootValue);

        var leftList = new List<int>();
        var rightList = new List<int>();

        for (int i = 1; i < numbers.Count; i++)
        {
            var current = numbers[i];
            if (current < rootValue)
            {
                leftList.Add(current);
            }
            else
            {
                rightList.Add(current);
            }
        }

        root.left = PreorderTraversal(preorder, leftList);
        root.right = PreorderTraversal(preorder, rightList);

        return root;
    }
}