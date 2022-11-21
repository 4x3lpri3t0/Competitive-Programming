using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

// http://codeforces.com/problemset/problem/222/A
public static class A___Shooshuns_and_Sequence
{
    private static void Solve()
    {
        //int n = ReadInt();
        //int k = ReadInt();
        //int[] a = ReadIntArray();

        //var q = new Queue<int>(a);

        //// Count how many swaps we need to get a uniform array.
        //int swaps = 0;
        //while (swaps < n)
        //{
        //    if (AreAllSameNumber(q))
        //    {
        //        Write(swaps);
        //        return;
        //    }

        //    var tempArray = q.ToArray();
        //    int kNumber = tempArray[k - 1];
        //    q.Enqueue(kNumber);
        //    q.Dequeue();

        //    swaps++;
        //}

        //if (swaps == n)
        //{
        //    // We cycled and swapped the whole array and still not able to get uniform array.
        //    Write(-1);
        //}
    }

    private static bool AreAllSameNumber(Queue<int> q)
    {
        int first = q.Peek();
        return q.All(x => x == first);
    }

    private static void CustomSwap(int[] array, int number)
    {
        array[0] = number;
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