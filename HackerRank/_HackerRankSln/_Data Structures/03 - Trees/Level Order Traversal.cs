using _HackerRankSln._Data_Structures._03___Trees;
using System;
using System.Collections.Generic;

// https://www.hackerrank.com/challenges/tree-level-order-traversal

public static class Level_Order_Traversal
{
    public static void LevelOrder(Node node)
    {
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(node);

        while (q.Count > 0)
        {
            Node n = q.Dequeue();
            if (n.left != null)
            {
                q.Enqueue(n.left);
            }

            if (n.right != null)
            {
                q.Enqueue(n.right);
            }

            Console.WriteLine(n.data + " ");
        }
    }
}