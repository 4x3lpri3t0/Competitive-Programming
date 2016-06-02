using System;

namespace _HackerRankSln._Data_Structures._03___Trees
{
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
}
