using System;
using System.Linq;

namespace CodeFights.Arcade.Intro.Level_2
{
    public class MatrixElementsSum
    {
        public static void Main()
        {
            var matrix = new int[][]
            {
                new int[] {0, 1, 1, 2},
                new int[] {0, 5, 0, 0},
                new int[] {2, 0, 3, 3},
            };
            Console.WriteLine(matrixElementsSum(matrix));
        }

        private static int matrixElementsSum(int[][] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix[0].Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    int current = matrix[j][i];
                    if (current == 0)
                        break;
                    else
                        sum += current;
                }
            }

            return sum;
        }
    }
}