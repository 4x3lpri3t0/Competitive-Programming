using _HackerRankSln._Data_Structures._03___Trees;
using System;

// https://www.hackerrank.com/challenges/tree-inorder-traversal

public static class Inorder_Traversal
{
    public static void InOrder(Node root)
    {
        if (root == null)
        {
            return;
        }

        InOrder(root.left);
        Console.WriteLine(root.data + " ");
        InOrder(root.right);
    }
}