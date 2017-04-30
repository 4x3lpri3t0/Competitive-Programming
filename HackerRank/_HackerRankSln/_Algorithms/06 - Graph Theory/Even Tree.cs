using System;
using System.Collections.Generic;

// https://www.hackerrank.com/challenges/even-tree

public static class Even_Tree
{
    private static int answer = 0;

    private static int DFS(int s, Dictionary<int, List<int>> graph, HashSet<int> visited)
    {
        int c = 0;
        visited.Add(s);

        // No child exists (only parent there)
        if (graph[s].Count == 1)
            return 1;

        foreach (var v in graph[s])
        {
            if (!visited.Contains(v))
            {
                c += DFS(v, graph, visited);
            }
        }

        // If child count in subtree is odd
        if (c % 2 == 1)
        {
            ++answer;
            return 0;
        }

        return 1;
    }

    public static void Main()
    {
        string[] data = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(data[0]);
        int m = Convert.ToInt32(data[1]);
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        for (int i = 1; i <= n; ++i)
            graph[i] = new List<int>();

        for (int i = 0; i < m; ++i)
        {
            data = Console.ReadLine().Split(' ');
            int v1 = Convert.ToInt32(data[0]);
            int v2 = Convert.ToInt32(data[1]);

            graph[v1].Add(v2);
            graph[v2].Add(v1);
        }

        answer = 0;
        DFS(1, graph, new HashSet<int>());
        Console.WriteLine(answer - 1);
    }
}