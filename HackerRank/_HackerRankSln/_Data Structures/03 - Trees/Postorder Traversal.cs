using _HackerRankSln._Data_Structures._03___Trees;
using System;

// https://www.hackerrank.com/challenges/tree-postorder-traversal

public static class Postorder_Traversal
{
    public static void PostOrder(Node node)
    {
        if (node == null)
        {
            return;
        }

        PostOrder(node.left);
        PostOrder(node.right);

        Console.WriteLine(node.data + " ");
    }
}