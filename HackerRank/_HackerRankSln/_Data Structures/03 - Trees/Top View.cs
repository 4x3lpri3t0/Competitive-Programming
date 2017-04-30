using _HackerRankSln._Data_Structures._03___Trees;
using System;
using System.Collections.Generic;
using System.Linq;

// https://www.hackerrank.com/challenges/tree-top-view

public static class Top_View
{
    public static void TopView(Node root)
    {
        Node curr = root;
        Stack<Node> stack = new Stack<Node>();

        // Getting left part
        while (curr != null)
        {
            stack.Push(curr);
            curr = curr.left;
        }

        while (stack.Count() > 0)
        {
            Node node = stack.Pop();
            Console.WriteLine(node.data + " ");
        }

        // Getting + printing right part
        curr = root.right;
        while (curr != null)
        {
            Console.WriteLine(curr.data + " ");
            curr = curr.right;
        }
    }
}