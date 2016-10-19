using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

public static class Heaps___Find_the_Running_Median
{
    public class MediumHeap
    {
        List<int> elements;

        public MediumHeap()
        {
            elements = new List<int>();
        }

        public void Add(int item)
        {
            if (elements.Count == 0)
            {
                elements.Add(item);
                return;
            }

            int lo = 0;
            int hi = elements.Count;

            while (lo < hi)
            {
                int count = elements.Count;
                int mid = (lo + hi) / 2;

                if (item < elements[mid])
                {
                    hi = (mid - 1 > 0) ? mid - 1 : 0;
                }
                else if (item > elements[mid])
                {
                    AdjustHiLoToUpperBound(ref lo, ref hi, count, mid);
                }
                else
                {
                    elements.Insert(mid, item);
                    return;
                }
            }

            if (item > elements[lo])
            {
                lo++;
            }

            elements.Insert(lo, item);
        }

        private static void AdjustHiLoToUpperBound(ref int lo, ref int hi, int count, int mid)
        {
            if (lo < count - 1)
            {
                if (mid + 1 < count)
                {
                    lo = mid + 1;
                }
                else
                {
                    lo = count - 1;
                }
            }
            else
            {
                hi = lo;
            }
        }

        public decimal PeekMedian()
        {
            if (elements.Count == 0)
            {
                return 0;
            }

            if (elements.Count % 2 == 1)
            {
                return elements[elements.Count / 2];
            }
            else
            {
                int k0 = elements[elements.Count / 2];
                int k1 = elements[elements.Count / 2 - 1];

                return (decimal)(k0 + k1) / 2;
            }
        }
    }

    private static void Solve()
    {
        int n = ReadInt();
        var heap = new MediumHeap();
        while (n-- > 0)
        {
            int v = ReadInt();
            heap.Add(v);
            var roundedMedian = Math.Round(heap.PeekMedian(), 1).ToString("#0.0");
            Write(roundedMedian);
        }
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
            //var thread = new Thread(new Heaps___Find_the_Running_Median().Solve, 1024 * 1024 * 128);
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