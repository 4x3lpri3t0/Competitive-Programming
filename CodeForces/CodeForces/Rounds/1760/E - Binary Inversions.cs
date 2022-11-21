using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

// AXEL TODO: Wrong answer on test 7

// https://codeforces.com/contest/1760/problem/E
public static class E___Binary_Inversions
{
    private static void Solve()
    {
        int T = ReadInt();
        while (T-- != 0)
        {
            int n = ReadInt();
            int[] A = ReadIntArray();

            int original = GetTotal(n, A);

            int[] B = new int[n];
            int[] C = new int[n];
            Array.Copy(A, B, n);
            Array.Copy(A, C, n);

            // Try flipping first cero to one
            for (int i = 0; i < n; i++)
            {
                if (B[i] == 0)
                {
                    B[i] = 1;
                    break;
                }
            }
            int firstFlipTotal = GetTotal(n, B);

            // Try flipping last one to cero
            for (int i = n - 1; i >= 0; i--)
            {
                if (C[i] == 1)
                {
                    C[i] = 0;
                    break;
                }
            }
            int secondFlipTotal = GetTotal(n, C);

            Write(Math.Max(original, Math.Max(firstFlipTotal, secondFlipTotal)));
        }
    }

    private static int GetTotal(int n, int[] A)
    {
        int[] B = new int[n];

        int tempSum = 0;
        for (int i = n - 1; i >= 0; i--)
        {
            tempSum += (A[i] == 0 ? 1 : 0);
            B[i] = tempSum;
        }

        int total = 0;
        for (int i = 0; i < n; i++)
        {
            total += (A[i] == 0 ? 0 : B[i]);
        }

        return total;
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
            //var thread = new Thread(new Word_Capitalization().Solve, 1024 * 1024 * 128);
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

    private static string[] ReadAndSplitLine()
    { return reader.ReadLine().Split(new[] { ' ', '\t', }, StringSplitOptions.RemoveEmptyEntries); }

    public static string Read()
    { while (currentLineTokens.Count == 0) currentLineTokens = new Queue<string>(ReadAndSplitLine()); return currentLineTokens.Dequeue(); }

    public static int ReadInt()
    { return int.Parse(Read()); }

    public static long ReadLong()
    { return long.Parse(Read()); }

    public static double ReadDouble()
    { return double.Parse(Read(), CultureInfo.InvariantCulture); }

    public static int[] ReadIntArray()
    { return ReadAndSplitLine().Select(int.Parse).ToArray(); }

    public static long[] ReadLongArray()
    { return ReadAndSplitLine().Select(long.Parse).ToArray(); }

    public static double[] ReadDoubleArray()
    { return ReadAndSplitLine().Select(s => double.Parse(s, CultureInfo.InvariantCulture)).ToArray(); }

    public static int[][] ReadIntMatrix(int numberOfRows)
    { int[][] matrix = new int[numberOfRows][]; for (int i = 0; i < numberOfRows; i++) matrix[i] = ReadIntArray(); return matrix; }

    public static int[][] ReadAndTransposeIntMatrix(int numberOfRows)
    {
        int[][] matrix = ReadIntMatrix(numberOfRows); int[][] ret = new int[matrix[0].Length][];
        for (int i = 0; i < ret.Length; i++) { ret[i] = new int[numberOfRows]; for (int j = 0; j < numberOfRows; j++) ret[i][j] = matrix[j][i]; }
        return ret;
    }

    public static string[] ReadLines(int quantity)
    { string[] lines = new string[quantity]; for (int i = 0; i < quantity; i++) lines[i] = reader.ReadLine().Trim(); return lines; }

    public static void WriteArray<T>(IEnumerable<T> array)
    { writer.WriteLine(string.Join(" ", array)); }

    public static void Write(params object[] array)
    { WriteArray(array); }

    public static void WriteLines<T>(IEnumerable<T> array)
    { foreach (var a in array) writer.WriteLine(a); }

    private class SDictionary<TKey, TValue> : Dictionary<TKey, TValue>
    {
        public new TValue this[TKey key]
        {
            get { return ContainsKey(key) ? base[key] : default(TValue); }
            set { base[key] = value; }
        }
    }

    private static T[] Init<T>(int size) where T : new()
    { var ret = new T[size]; for (int i = 0; i < size; i++) ret[i] = new T(); return ret; }

    #endregion Read / Write
}