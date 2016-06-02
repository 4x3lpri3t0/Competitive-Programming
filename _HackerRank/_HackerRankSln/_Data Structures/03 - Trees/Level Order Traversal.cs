using System;
using System.Collections.Generic;

namespace _HackerRankSln._Data_Structures._03___Trees
{
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
}
