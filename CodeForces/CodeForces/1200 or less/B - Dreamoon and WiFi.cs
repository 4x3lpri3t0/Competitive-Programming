#region Usings
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

using static System.Math;
#endregion

// https://codeforces.com/problemset/problem/476/B
public class B___Dreamoon_and_WiFi
{
    public static long combination(long n, long r)
    {
        long i;
        long ans;
        long x;
        long k = 1;

        x = Math.Max(r, n - r);
        ans = 1;
        for (i = n; i > x; i--)
        {
            ans = ans * i;
            ans = ans / k;
            k++;
        }
        return ans;

    }

    

    private static void Solve()
    {
        string initial = Read();
        string received = Read();

        int iPlus = 0, iMinus = 0;
        int rPlus = 0, rMinus = 0, rQuest = 0;
        double prob = 0;
        int questAsPlus = 0;
        int questAsMinus = 0;
        string result;
        int endPosition = 0;
        int endPositionR = 0;

        for (int i = 0; i < initial.Length; i++)
        {
            switch (initial[i])
            {
                case '+':
                    iPlus++;
                    endPosition++;
                    break;
                case '-':
                    iMinus++;
                    endPosition--;
                    break;
                default:
                    break;
            }
            switch (received[i])
            {
                case '+':
                    rPlus++;
                    endPositionR++;
                    break;
                case '-':
                    rMinus++;
                    endPositionR--;
                    break;
                case '?':
                    rQuest++;
                    break;
                default:
                    break;
            }
        }
        int originalQuest = rQuest;
        int originalPlus = rPlus;
        int originalMinus = rMinus;

        if (rMinus == iMinus && rPlus == iPlus) prob = 1;
        else if (iMinus < rMinus || iPlus < rPlus) prob = 0;
        else
        {
            if (iMinus > rMinus)
            {
                while (iMinus > rMinus && rQuest > 0)
                {
                    rMinus++;
                    rQuest--;
                    questAsMinus++;
                }
            }
            if (iPlus > rPlus)
            {
                while (iPlus > rPlus && rQuest > 0)
                {
                    rPlus++;
                    rQuest--;
                    questAsPlus++;
                }
            }

            if (rMinus != iMinus || rPlus != iPlus) prob = 0;
            else
            {
                int distance = Math.Abs(endPosition - endPositionR);
                if (endPosition < endPositionR) distance = -distance;

                //Console.WriteLine("distance: {0}", distance);
                //Console.WriteLine("minus: {0}",questAsMinus);
                //Console.WriteLine("plus: {0}", questAsPlus);

                double possibleWays = combination(questAsMinus + questAsPlus, questAsPlus);
                //Console.WriteLine("possible ways: {0}", possibleWays);

                prob = possibleWays / Math.Pow(2, originalQuest);
                result = prob.ToString();

            }

        }
        result = prob.ToString();
        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] == ',') Console.Write('.');
            else Console.Write(result[i]);
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