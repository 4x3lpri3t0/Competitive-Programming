using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _HackerRankSln.Cracking_the_Coding_Interview
{
    public class DFS___Connected_Cell_in_a_Grid
    {
        private static bool[][] visited;

        private static void Solve()
        {
            int M = ReadInt();
            int N = ReadInt();

            int[][] grid = ReadIntMatrix(M);

            // Init visited matrix
            visited = new bool[M][];
            for (int i = 0; i < visited.Length; i++)
            {
                visited[i] = new bool[N];
            }

            GetMaxZone(grid, M, N);
        }

        private static void GetMaxZone(int[][] grid, int M, int N)
        {
            int max = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (!visited[i][j])
                    {
                        int currZoneValue = FindZone(grid, i, j, M, N);
                        max = Math.Max(max, currZoneValue);
                    }
                }
            }

            Console.WriteLine(max);
        }

        private static int FindZone(
            int[][] grid, int i, int j, int M, int N)
        {
            // Check boundaries
            if (i < 0 || j < 0 || i >= M || j >= N)
                return 0;

            // Check visited
            if (visited[i][j])
                return 0;

            // Visit
            visited[i][j] = true;

            // Check value
            if (grid[i][j] == 0)
                return 0;

            // Propagate
            else return 1 +
                FindZone(grid, i - 1, j - 1, M, N) +
                FindZone(grid, i - 1, j, M, N) +
                FindZone(grid, i - 1, j + 1, M, N) +
                FindZone(grid, i, j - 1, M, N) +
                FindZone(grid, i, j + 1, M, N) +
                FindZone(grid, i + 1, j - 1, M, N) +
                FindZone(grid, i + 1, j, M, N) +
                FindZone(grid, i + 1, j + 1, M, N);
        }

        #region Main

        private static TextReader reader;
        private static TextWriter writer;

        public static void Main()
        {
#if DEBUG

            //reader = new StreamReader("C:\\Users\\Axel\\Desktop\\input.txt");
            reader = new StreamReader(Console.OpenStandardInput());
            writer = Console.Out;

            //writer = new StreamWriter("..\\..\\output.txt");
#else
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        //reader = new StreamReader("input.txt");
        //writer = new StreamWriter("output.txt");
#endif
            try
            {
                Solve();

                //var thread = new Thread(new String_Task().Solve, 1024 * 1024 * 128);
                //thread.Start();
                //thread.Join();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
#if DEBUG
#else
            throw;
#endif
            }
            reader.Close();
            writer.Close();
        }

        #endregion Main

        #region Read / Write
        private static Queue<string> currentLineTokens = new Queue<string>();
        private static string[] ReadAndSplitLine() { return reader.ReadLine().Split(new[] { ' ', '\t', }, StringSplitOptions.RemoveEmptyEntries); }
        public static string Read() { while (currentLineTokens.Count == 0) currentLineTokens = new Queue<string>(ReadAndSplitLine()); return currentLineTokens.Dequeue(); }
        public static int ReadInt() { return int.Parse(Read()); }
        public static long ReadLong() { return long.Parse(Read()); }
        public static double ReadDouble() { return double.Parse(Read(), CultureInfo.InvariantCulture); }
        public static int[] ReadIntArray() { return ReadAndSplitLine().Select(int.Parse).ToArray(); }
        public static long[] ReadLongArray() { return ReadAndSplitLine().Select(long.Parse).ToArray(); }
        public static double[] ReadDoubleArray() { return ReadAndSplitLine().Select(s => double.Parse(s, CultureInfo.InvariantCulture)).ToArray(); }
        public static int[][] ReadIntMatrix(int numberOfRows) { int[][] matrix = new int[numberOfRows][]; for (int i = 0; i < numberOfRows; i++) matrix[i] = ReadIntArray(); return matrix; }
        public static int[][] ReadAndTransposeIntMatrix(int numberOfRows)
        {
            int[][] matrix = ReadIntMatrix(numberOfRows); int[][] ret = new int[matrix[0].Length][];
            for (int i = 0; i < ret.Length; i++) { ret[i] = new int[numberOfRows]; for (int j = 0; j < numberOfRows; j++) ret[i][j] = matrix[j][i]; }
            return ret;
        }
        public static string[] ReadLines(int quantity) { string[] lines = new string[quantity]; for (int i = 0; i < quantity; i++) lines[i] = reader.ReadLine().Trim(); return lines; }
        public static void WriteArray<T>(IEnumerable<T> array) { writer.WriteLine(string.Join(" ", array)); }
        public static void Write(params object[] array) { WriteArray(array); }
        public static void WriteLines<T>(IEnumerable<T> array) { foreach (var a in array) writer.WriteLine(a); }
        private class SDictionary<TKey, TValue> : Dictionary<TKey, TValue>
        {
            public new TValue this[TKey key]
            {
                get { return ContainsKey(key) ? base[key] : default(TValue); }
                set { base[key] = value; }
            }
        }
        private static T[] Init<T>(int size) where T : new() { var ret = new T[size]; for (int i = 0; i < size; i++) ret[i] = new T(); return ret; }
        #endregion
    }
}
