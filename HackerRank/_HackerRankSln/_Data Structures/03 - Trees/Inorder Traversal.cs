using System;

namespace _HackerRankSln._Data_Structures._03___Trees
{
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
}
