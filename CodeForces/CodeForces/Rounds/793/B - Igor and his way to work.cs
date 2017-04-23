using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

public class B___Igor_and_his_way_to_work
{
    private static int N;
    private static int M;
    private static char[,] matrix;
    private static bool[,] check;
    private static bool found = false;

    private static void Solve()
    {
        N = ReadInt();
        M = ReadInt();

        int startY = -1;
        int startX = -1;

        matrix = new char[N, M];
        for (int i = 0; i < N; i++)
        {
            string row = Read();
            for (int j = 0; j < M; j++)
            {
                char c = row[j];
                matrix[i, j] = c;

                if (c == 'S')
                {
                    startY = i;
                    startX = j;
                }
            }
        }

        check = new bool[N, M];
        int turns = 0;
        NeighborIsT(startX, startY - 1, turns, "up");
        NeighborIsT(startX, startY + 1, turns, "down");
        NeighborIsT(startX - 1, startY, turns, "left");
        NeighborIsT(startX + 1, startY, turns, "right");

        Write(found ? "YES" : "NO");
    }

    private static void NeighborIsT(int x, int y, int turns, string prevDirection)
    {
        if (x < 0 || x > M - 1) return;
        if (y < 0 || y > N - 1) return;

        if (check[y, x] || matrix[y, x] == '*' || found || turns > 2) return;

        check[y, x] = true;

        if (matrix[y, x] == 'T')
        {
            found = true;
        }

        NeighborIsT(x, y - 1, prevDirection == "up" ? turns : turns++, "up");
        NeighborIsT(x, y + 1, prevDirection == "down" ? turns : turns++, "down");
        NeighborIsT(x - 1, y, prevDirection == "left" ? turns : turns++, "left");
        NeighborIsT(x + 1, y, prevDirection == "right" ? turns : turns++, "right");
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