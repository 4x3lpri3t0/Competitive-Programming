using System;

namespace _HackerRankSln._Data_Structures._03___Trees
{
    public static class Swap_Nodes
    {
        public static void Swap()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] leftChildren = new int[n];
            int[] rightChildren = new int[n];
            for (var i = 0; i < n; i++)
            {
                string[] childIndexes = Console.ReadLine().Split(new char[] { ' ' });
                leftChildren[i] = Convert.ToInt32(childIndexes[0]) - 1;
                rightChildren[i] = Convert.ToInt32(childIndexes[1]) - 1;
            }
            int t = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < t; i++)
            {
                int k = Convert.ToInt32(Console.ReadLine());
                Swap(leftChildren, rightChildren, k);
                PrintTree(leftChildren, rightChildren);
            }
        }

        private static void PrintTree(int[] leftChildren, int[] rightChildren)
        {
            Console.WriteLine(NodeString(leftChildren, rightChildren, 0));
        }

        private static string NodeString(int[] leftChildren, int[] rightChildren, int node)
        {
            string nodeString = "";
            if (leftChildren[node] >= 0)
            {
                nodeString += NodeString(leftChildren, rightChildren, leftChildren[node]) + " ";
            }
            nodeString += (node + 1).ToString();
            if (rightChildren[node] >= 0)
            {
                nodeString += " " + NodeString(leftChildren, rightChildren, rightChildren[node]);
            }
            return nodeString;
        }

        private static void Swap(int[] leftChildren, int[] rightChildren, int k)
        {
            SwapNode(leftChildren, rightChildren, k, 0, 1);
        }

        private static void SwapNode(int[] leftChildren, int[] rightChildren, int k, int node, int d)
        {
            if (node < 0)
            {
                return;
            }
            if (d % k == 0)
            {
                int hold = leftChildren[node];
                leftChildren[node] = rightChildren[node];
                rightChildren[node] = hold;
            }
            SwapNode(leftChildren, rightChildren, k, leftChildren[node], d + 1);
            SwapNode(leftChildren, rightChildren, k, rightChildren[node], d + 1);
        }
    }
}