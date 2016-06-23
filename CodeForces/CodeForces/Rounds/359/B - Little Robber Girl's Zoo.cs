using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

public static class B___Little_Robber_Girl_s_Zoo
{
    private static void Solve()
    {
        int N = ReadInt();
        long[] array = ReadLongArray();
        // Used to avoid checking every time if the current array is ordered
        bool alreadyOrdered = false;

        while (!alreadyOrdered)
        {
            int l = -1;
            int r = -1;
            alreadyOrdered = true;
            IteratePairs(0, N, array, ref alreadyOrdered, ref l, ref r);
        }

        alreadyOrdered = false;

        while (!alreadyOrdered)
        {
            int l = -1;
            int r = -1;
            alreadyOrdered = true;
            IteratePairs(1, N, array, ref alreadyOrdered, ref l, ref r);
        }
    }

    private static void IteratePairs(int startingAt, int N, long[] array, ref bool alreadyOrdered, ref int l, ref int r)
    {
        for (int i = startingAt; i < N - 1; i += 2)
        {
            int currentL = i;
            int currentR = i + 1;
            if (array[currentL] > array[currentR])
            {
                alreadyOrdered = false;
                Swap(array, currentL, currentR);

                if (l == -1)
                {
                    l = currentL;
                }
                if (currentR > r)
                {
                    r = currentR;
                }
            }
        }
        // We already started the swapping cycle, and now cycle finishes
        if (l != -1 && r != -1)
        {
            // Output is 1-based index
            Write((l + 1) + " " + (r + 1));
        }
    }

    static void Swap(long[] array, long a, long b)
    {
        long temp = array[a];
        array[a] = array[b];
        array[b] = temp;
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
            //var thread = new Thread(new B___Little_Robber_Girl_s_Zoo().Solve, 1024 * 1024 * 128);
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