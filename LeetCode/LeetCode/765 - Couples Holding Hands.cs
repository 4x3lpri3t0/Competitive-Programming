// https://leetcode.com/problems/couples-holding-hands/
public partial class Solution
{
    public class UF
    {
        private int[] parents;
        public int count;

        public UF(int n)
        {
            parents = new int[n];
            for (int i = 0; i < n; i++)
            {
                parents[i] = i;
            }
            count = n;
        }

        private int find(int i)
        {
            if (parents[i] == i)
            {
                return i;
            }
            parents[i] = find(parents[i]);
            return parents[i];
        }

        public void union(int i, int j)
        {
            int a = find(i);
            int b = find(j);
            if (a != b)
            {
                parents[a] = b;
                count--;
            }
        }
    }

    public int MinSwapsCouples(int[] row)
    {
        // N couples
        int N = row.Length / 2;

        UF uf = new UF(N);

        for (int i = 0; i < N; i++)
        {
            int a = row[2 * i];
            int b = row[2 * i + 1];
            uf.union(a / 2, b / 2);
        }

        // N couples minus amount of joined couples
        return N - uf.count;
    }
}
