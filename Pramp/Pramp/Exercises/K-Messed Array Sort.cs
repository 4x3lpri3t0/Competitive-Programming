using System;

// https://www.pramp.com/challenge/XdMZJgZoAnFXqwjJwnBZ
partial class Solution
{
    internal class MinHeap
    {
        public static int[] Data;
        public MinHeap(int size)
        {
            Data = new int[0];
        }

        public int ExtractMin()
        {
            Array.Sort(Data);
            var minimumValue = Data[0];
            int length = Data.Length;
            var newData = new int[length - 1];
            for (int i = 1; i < length; i++)
            {
                newData[i - 1] = Data[i];
            }

            Data = newData;
            return minimumValue;
        }

        public int Count()
        {
            return Data.Length;
        }

        public void Insert(int value)
        {
            int length = Data.Length;
            var newData = new int[length + 1];
            for (int i = 0; i < length; i++)
            {
                newData[i] = Data[i];
            }

            newData[length] = value;

            Data = newData;
        }
    }

    public static int[] SortKMessedArray(int[] arr, int k)
    {
        if (arr == null || arr.Length == 0 || k < 0)
        {
            return new int[0];
        }

        int length = arr.Length;

        // Build a heap first 
        var size = Math.Min(length, k + 1);
        var minHeap = new MinHeap(size);

        for (int i = 0; i < size; i++)
        {
            minHeap.Insert(arr[i]);
        }

        var sorted = new int[length];
        int start = 0;
        
        // Insert min on the front of the window, iterate array on the end of the window
        for (int end = size; end < length; end++)
        {
            sorted[start] = minHeap.ExtractMin();
            start++;

            var visit = arr[end];
            minHeap.Insert(visit);
        }

        while (minHeap.Count() > 0)
        {
            sorted[start] = minHeap.ExtractMin();
            start++;
        }

        return sorted;
    }

    public static void KMessedArraySort()
    {
        int[] arr = new int[] { 1, 4, 5, 2, 3, 7, 8, 6, 10, 9 };
        int[] result = SortKMessedArray(arr, 2);

        Console.Write(string.Join(" ", result));
    }
}

//   K + 1 = 3, 1, 4, 5
// index = 1 , 2, 3, K sorted array, find minimum O(klogk)
// minimum heap -> O(1)  to extract, O(logk)
// build a minimum heap first, k + 1
// extract minimum heap, visit next element
// extract -> iterate 
// time complexity O(k + 1) + O(1) * N + O(logk)(N - k) = O(Nlogk), O(k + 1), 
// MinimumHeap - API - ExtractMin, Insert - O(nlogn)  sort Array.Sort 
// SortedSet - 