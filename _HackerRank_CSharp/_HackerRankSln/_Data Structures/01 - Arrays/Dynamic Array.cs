using System;
using System.Collections;

namespace _HackerRankSln._Data_Structures._01___Arrays
{
    public static class Dynamic_Array
    {
        public static void PrintUpdatedLastAnswer()
        {
            string[] tempRow;
            int N, Q;
            GetInput(out tempRow, out N, out Q);

            ArrayList[] seqList = CreateArrayLists(N);

            long lastAns = 0;

            for (int i = 0; i < Q; i++)
            {
                int qType;
                long x, y;
                GetRowInput(out tempRow, out qType, out x, out y);

                // Calculate index for seqList
                long seqIndex = ((x ^ lastAns) % N);

                if (qType == 1)
                {
                    // Insert y at the end of that seq
                    seqList[seqIndex].Add(y);
                }
                else // qType == 2
                {
                    int indx = (int)(y % seqList[seqIndex].Count);
                    lastAns = (long)seqList[seqIndex][indx];

                    // Output
                    Console.WriteLine(lastAns);
                }
            }
        }

        private static void GetRowInput(out string[] tempRow, out int qType, out long x, out long y)
        {
            tempRow = Console.ReadLine().Split(' ');
            int[] row = Array.ConvertAll(tempRow, int.Parse);
            qType = row[0];
            x = row[1];
            y = row[2];
        }

        private static ArrayList[] CreateArrayLists(int N)
        {
            var seqList = new ArrayList[N];
            for (int i = 0; i < N; i++)
            {
                seqList[i] = new ArrayList();
            }

            return seqList;
        }

        private static void GetInput(out string[] tempRow, out int N, out int Q)
        {
            tempRow = Console.ReadLine().Split(' ');
            int[] firstRow = Array.ConvertAll(tempRow, int.Parse);
            N = firstRow[0];
            Q = firstRow[1];
        }
    }
}
