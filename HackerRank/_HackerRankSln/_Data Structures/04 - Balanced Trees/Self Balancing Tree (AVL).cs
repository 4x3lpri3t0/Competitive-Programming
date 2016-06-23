using System;

namespace _HackerRankSln._Data_Structures._04___Balanced_Trees
{
    public static class Self_Balancing_Tree__AVL_
    {
        public class Node
        {
            public int val;    //Value
            public int ht;     //Height
            public Node left;  //Left child
            public Node right; //Right child
        }

        static int H(Node x)
        {
            return x != null ? x.ht : -1;
        }

        static void UpdateH(Node x)
        {
            if (x == null) return;
            x.ht = Math.Max(H(x.left), H(x.right)) + 1;
        }

        public static Node Insert(Node root, int val)
        {
            if (root == null)
            {
                Node n = new Node();
                n.val = val;
                n.ht = 0;
                return n;
            }
            if (val < root.val)
            {
                root.left = Insert(root.left, val);
                int bf = H(root.left) - H(root.right);
                if (bf > 1)
                {
                    Node A = root.left;
                    int bfl = H(root.left.left) - H(root.left.right);
                    if (bfl < 0)
                    {
                        Node B = root.left.right;
                        root.left = B;
                        A.right = B.left;
                        B.left = A;
                        UpdateH(A);
                        UpdateH(B);
                    }
                }
                if (bf > 1)
                {
                    Node A = root.left;
                    Node B = A.left;
                    root.left = A.right;
                    A.right = root;
                    UpdateH(root);
                    UpdateH(A);
                    root = A;
                }
            }
            else
            {
                root.right = Insert(root.right, val);
                int bf = H(root.left) - H(root.right);
                if (bf < -1)
                {
                    Node A = root.right;
                    int bfl = H(root.right.left) - H(root.right.right);
                    if (bfl > 0)
                    {
                        Node B = root.right.left;
                        root.right = B;
                        A.left = B.right;
                        B.right = A;
                        UpdateH(A);
                        UpdateH(B);
                    }
                }
                if (bf < -1)
                {
                    Node A = root.right;
                    Node B = A.right;
                    root.right = A.left;
                    A.left = root;
                    UpdateH(root);
                    UpdateH(A);
                    root = A;
                }
            }

            UpdateH(root);

            return root;
        }

    }
}
