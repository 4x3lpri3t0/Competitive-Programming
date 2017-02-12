using System;

/*

BST Successor Search

Given a node n in a binary search tree,
explain and code the most efficient way to find the successor of n.

*/

public class BST_Successor
{
    private class Node
    {
        public Node left;
        public Node right;
        public Node parent;
        public int val;

        public Node(int val, Node parent)
        {
            this.val = val;
            this.parent = parent;
        }
    }

    public static void Main()
    {
        Node n1 = new Node(4, null);

        n1.left = new Node(2, n1);
        n1.right = new Node(6, n1);

        n1.left.left = new Node(1, n1.left);
        n1.left.right = new Node(3, n1.left);

        n1.right.left = new Node(5, n1.right);
        n1.right.right = new Node(7, n1.right);

        Node succOf3 = GetSuccessor(n1.left.right);
        Node succOf4 = GetSuccessor(n1);

        Console.WriteLine("Node 3's succesor is " + succOf3.val);
        Console.WriteLine("Node 4's successor is " + succOf4.val);
    }

    /* 
    *          4
    *     2          6
    *   1   3      5    7
    *   
    *   Succ 3 -> 4 
    *   Succ 4 -> 6
    */
    private static Node GetSuccessor(Node node)
    {
        if (node == null)
        {
            return null;
        }

        if (node.right == null) // Go up
        {
            Node child;
            while (node.parent != null)
            {
                child = node;
                node = node.parent;

                if (node.val < child.val)
                {
                    continue;
                }
                else
                {
                    return node;
                }
            }

            return null;
        }
        else 
        {
            // There is a right node
            // -> leftmost of it is going to be succesor
            return GetMin(node.right);
        }
    }

    private static Node GetMin(Node node)
    {
        while (node.left != null)
        {
            node = node.left;
        }

        return node;
    }
}

/* Get succesor of 3:
 * 
 *          4
 *     2          6
 *   1   3  
 *   
 *  3 -> 2 -> 4
 */