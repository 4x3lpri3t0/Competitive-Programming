using System;

namespace _HackerRankSln._Data_Structures._01___Arrays
{
    public static class _2D_Array___DS
    {
        public static void FindMaxHourglass()
        {
            int[][] arr = GetInput();

            int maxHourglass = int.MinValue;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int row1 = arr[i][j] + arr[i][j + 1] + arr[i][j + 2];
                    int row2 = arr[i + 1][j + 1];
                    int row3 = arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    int total = row1 + row2 + row3;
                    if (total > maxHourglass)
                        maxHourglass = total;
                }
            }

            Console.WriteLine(maxHourglass);
        }

        private static int[][] GetInput()
        {
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            return arr;
        }
    }
}
