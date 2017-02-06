using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    public List<int> spiralOrder(List<List<int>> A)
    {
        int[][] matrix = A.Select(a => a.ToArray()).ToArray();
        var result = new List<int>();

        int row = 0;
        int col = 0;
        string direction = "right";
        int R = matrix.Length;
        int C = matrix[0].Length;
        int maxPositions = C * R;
        int cShrink = 0;
        int rShrink = 0;

        for (int i = 1; i <= maxPositions; i++)
        {
            if (direction == "right" && col > C - 1 - cShrink)
            {
                direction = "down";
                col--; // undo last
                row++;
            }
            else if (direction == "down" && row > R - 1 - rShrink)
            {
                direction = "left";
                row--; // undo last
                col--;

            }
            else if (direction == "left" && col < 0 + cShrink)
            {
                direction = "up";
                col++; // undo last
                row--;

                // Shrink matrix
                rShrink++;
                cShrink++;
            }
            else if (direction == "up" && row < 0 + rShrink)
            {
                direction = "right";
                row++; // undo last
                col++;
            }

            result.Add(matrix[row][col]);

            // MOVE TO NEXT POS
            if (direction == "right")
            {
                col++;
            }
            else if (direction == "down")
            {
                row++;
            }
            else if (direction == "left")
            {
                col--;
            }
            else // "up"
            {
                row--;
            }
        }

        return result;
    }
}