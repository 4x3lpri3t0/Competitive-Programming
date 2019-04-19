using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using static System.Math;

// https://codeforces.com/contest/1154/problem/C
public class GourmetCat
{
    private static void Solve()
    {
        int[] a = ReadIntArray();
        int[] week = new int[14] { 0, 1, 2, 0, 2, 1, 0, 0, 1, 2, 0, 2, 1, 0, };
        
        // Get maximum common weeks
        int nWeeks = Min(a[0] / 3, Min(a[1] / 2, a[2] / 2));
        a[0] -= nWeeks * 3;
        a[1] -= nWeeks * 2;
        a[2] -= nWeeks * 2;

        // Add extra days that conform less than a week
        int max = 0;
        for (int i = 0; i < 7; i++)
        {
            int[] aClone = (int[])a.Clone();
            int j;
            for (j = i; j < i + 7; j++)
            {
                if (aClone[week[j]] == 0)
                    break;
                aClone[week[j]]--;
            }

            if (j - i > max)
                max = j - i;
        }

        Write(nWeeks * 7 + max);
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

    private static string[] ReadAndSplitLine()
    {
        return reader.ReadLine().Split(new[] { ' ', '\t', }, StringSplitOptions.RemoveEmptyEntries);
    }

    public static string Read()
    {
        while (currentLineTokens.Count == 0) currentLineTokens = new Queue<string>(ReadAndSplitLine()); return currentLineTokens.Dequeue();
    }

    public static int ReadInt()
    {
        return int.Parse(Read());
    }

    public static long ReadLong()
    {
        return long.Parse(Read());
    }

    public static double ReadDouble()
    {
        return double.Parse(Read(), CultureInfo.InvariantCulture);
    }

    public static int[] ReadIntArray()
    {
        return ReadAndSplitLine().Select(int.Parse).ToArray();
    }

    public static long[] ReadLongArray()
    {
        return ReadAndSplitLine().Select(long.Parse).ToArray();
    }

    public static double[] ReadDoubleArray()
    {
        return ReadAndSplitLine().Select(s => double.Parse(s, CultureInfo.InvariantCulture)).ToArray();
    }

    public static int[][] ReadIntMatrix(int numberOfRows)
    {
        int[][] matrix = new int[numberOfRows][]; for (int i = 0; i < numberOfRows; i++) matrix[i] = ReadIntArray(); return matrix;
    }

    public static int[][] ReadAndTransposeIntMatrix(int numberOfRows)
    {
        int[][] matrix = ReadIntMatrix(numberOfRows); int[][] ret = new int[matrix[0].Length][];
        for (int i = 0; i < ret.Length; i++) { ret[i] = new int[numberOfRows]; for (int j = 0; j < numberOfRows; j++) ret[i][j] = matrix[j][i]; }
        return ret;
    }

    public static string[] ReadLines(int quantity)
    {
        string[] lines = new string[quantity]; for (int i = 0; i < quantity; i++) lines[i] = reader.ReadLine().Trim(); return lines;
    }

    public static void WriteArray<T>(IEnumerable<T> array)
    {
        writer.WriteLine(string.Join(" ", array));
    }

    public static void Write(params object[] array)
    {
        WriteArray(array);
    }

    public static void WriteLines<T>(IEnumerable<T> array)
    {
        foreach (var a in array) writer.WriteLine(a);
    }

    private class SDictionary<TKey, TValue> : Dictionary<TKey, TValue>
    {
        public new TValue this[TKey key]
        {
            get { return ContainsKey(key) ? base[key] : default(TValue); }
            set { base[key] = value; }
        }
    }

    private static T[] Init<T>(int size) where T : new()
    {
        var ret = new T[size]; for (int i = 0; i < size; i++) ret[i] = new T(); return ret;
    }

    #endregion Read / Write
}
