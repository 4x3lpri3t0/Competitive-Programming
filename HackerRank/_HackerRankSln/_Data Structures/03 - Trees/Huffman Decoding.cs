using System;
using System.Linq;

// https://www.hackerrank.com/challenges/tree-huffman-decoding

public static class Huffman_Decoding
{
    public class Node
    {
        public int frequency; // the frequency of this tree
        public char data;
        public Node left, right;
    }

    public static void Decode(string str, Node root)
    {
        Node node = root;

        for (int i = 0; i < str.Length; i++)
        {
            if (str.ElementAt(i) == '1')
            {
                node = node.right;
            }
            else
            {
                node = node.left;
            }

            if (IsLeaf(node))
            {
                Console.Write(node.data);
                node = root;
            }
        }

        Console.WriteLine();
    }

    private static bool IsLeaf(Node node)
    {
        return node.left == null && node.right == null;
    }
}