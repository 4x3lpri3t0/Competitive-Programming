using System.Collections.Generic;

// https://leetcode.com/problems/number-of-recent-calls/
public class RecentCounter
{
    Queue<int> q;

    public RecentCounter()
    {
        q = new Queue<int>();
    }

    public int Ping(int t)
    {
        while (q.Count != 0 && t - q.Peek() > 3000)
            q.Dequeue();

        q.Enqueue(t);

        return q.Count;
    }
}