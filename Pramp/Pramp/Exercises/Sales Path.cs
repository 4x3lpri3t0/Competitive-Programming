using System;

// https://www.pramp.com/challenge/15oxrQx6LjtQj9JK9XqA
partial class Solution
{
    public class SalesNode
    {
        public int cost;
        public SalesNode[] children;
        //public SalesNode parent;
    }

    public static int GetCheapestCost(SalesNode rootNode)
    {
        if (rootNode == null)
            return 0;

        bool noChildren = rootNode.children == null || rootNode.children.Length == 0;
        var current = rootNode.cost; // 0

        if (noChildren)
            return current;

        var minSalesPath = int.MaxValue;
        foreach (var child in rootNode.children)
        {
            minSalesPath = Math.Min(minSalesPath, current + GetCheapestCost(child)); // DFS
        }

        return minSalesPath;
    }

    public static void SalesPath()
    {
        var root = new SalesNode();
        root.cost = 0;

        // left subtree
        var root5 = new SalesNode();
        root5.cost = 5;

        var root4 = new SalesNode();
        root4.cost = 4;

        root5.children = new SalesNode[] { root4 };

        // right subtree
        var root6 = new SalesNode();
        root6.cost = 6;

        var root5B = new SalesNode();
        root5B.cost = 5;

        var root1 = new SalesNode();
        root1.cost = 1;

        root6.children = new SalesNode[] { root1, root5B };

        // root
        root.children = new SalesNode[] { root5, root6 };

        Console.WriteLine(GetCheapestCost(root)); // 7
    }
}