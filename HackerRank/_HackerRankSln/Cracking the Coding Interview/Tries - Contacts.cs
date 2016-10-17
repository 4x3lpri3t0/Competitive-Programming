using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

public static class Tries___Contacts
{
    private class Node
    {
        internal char Value;
        internal int Words = 0;
        internal List<Node> Children = new List<Node>();

        internal Node(char value)
        {
            this.Value = value;
            this.Words = 1;
        }

        internal Node()
        {
        }

        internal void Add(string word)
        {
            char value = word[0];

            if (!ContainsChild(value))
            {
                var child = new Node(value);
                if (word.Length > 1)
                {
                    child.Add(word.Substring(1));
                }

                this.Children.Add(child);
            }
            else
            {
                AddToResponsibleChild(word);
            }
        }

        internal bool ContainsChild(char value)
        {
            return this.Children.Any(x => x.Value == value);
        }

        internal void AddToResponsibleChild(string word)
        {
            var child = this.Children.First(x => x.Value == word[0]);
            child.Words++;
            child.Add(word.Substring(1));
        }

        internal int Find(string word)
        {
            char c = word[0];
            var child = this.Children.FirstOrDefault(x => x.Value == c);
            if (child == null)
            {
                return 0;
            }

            if (word.Length > 1)
                return child.Find(word.Substring(1));
            else // Last char
            {
                if (child.Value == word[0])
                {
                    return child.Words;
                }

                return 0;
            }
        }
    }

    private static void Solve()
    {
        int n = ReadInt();
        var trie = new Node();

        while (n-- > 0)
        {
            string[] tokens = ReadAndSplitLine();
            string op = tokens[0];
            string word = tokens[1];

            if (op == "add")
            {
                // add
                trie.Add(word);
            }
            else
            {
                // find
                Write(trie.Find(word));
            }
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
            //var thread = new Thread(new Strings___Making_Anagrams().Solve, 1024 * 1024 * 128);
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