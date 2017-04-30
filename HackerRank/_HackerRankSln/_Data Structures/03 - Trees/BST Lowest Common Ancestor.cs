using _HackerRankSln._Data_Structures._03___Trees;
using System;

// https://www.hackerrank.com/challenges/binary-search-tree-lowest-common-ancestor
// http://stackoverflow.com/questions/31409989/what-is-the-best-approach-binary-search-tree-lowest-common-ancestor-using-onl

public static class BST_Lowest_Common_Ancestor
{
    public static Node LCA(Node root, int v1, int v2)
    {
        int min = Math.Min(v1, v2);
        int max = Math.Max(v1, v2);

        while (root.data < min || root.data > max)
        {
            if (root.data < min)
                root = root.right;
            else if (root.data > max)
                root = root.left;
        }

        return root;
    }
}