using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

public static class Shil_and_Square_Sum
{
    const int MODULUS = 1000000007;

    private static void Solve()
    {
        int N = ReadInt();
        int K = ReadInt();
        int[] A = ReadIntArray();

        int[,] sum = new int[N, 3];
        long s0 = 0, s1 = 0, s2 = 0;

        for (int i = 0; i < N; ++i)
        {
            long square = (i + 1L) * (i + 1) % MODULUS;

            sum[i, 0] = (int)(s0 = (s0 + A[i]) % MODULUS);
            sum[i, 1] = (int)(s1 = (s1 + A[i] * (i + 1L)) % MODULUS);
            sum[i, 2] = (int)(s2 = (s2 + A[i] * square) % MODULUS);
        }

        int[] result = new int[N - K + 1];

        s0 = s1 = s2 = 0;

        for (int l = 0, r = K - 1; r < N; ++l, ++r)
        {
            s0 = sum[r, 0] - (l > 0 ? sum[l - 1, 0] : 0);
            s1 = sum[r, 1] - (l > 0 ? sum[l - 1, 1] : 0);
            s2 = sum[r, 2] - (l > 0 ? sum[l - 1, 2] : 0);

            int res = (int)((s2 - 2 * l * s1 + (long)l * l % MODULUS * s0) % MODULUS);

            result[l] = res + (res < 0 ? MODULUS : 0);
        }

        WriteArray(result);
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
            //var thread = new Thread(new Shil_and_Square_Sum().Solve, 1024 * 1024 * 128);
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

    #endregion

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