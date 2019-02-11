using System;

// https://leetcode.com/problems/image-smoother/
public partial class Solution
{
    public int[,] ImageSmoother(int[,] M)
    {
        int[,] newM = (int[,])M.Clone();

        for (int i = 0; i < M.GetLength(0); i++)
        {
            for (int j = 0; j < M.GetLength(1); j++)
            {
                int dividend = 0;
                int divisor = 0;

                // Top row
                if (j > 0)
                {
                    // Left
                    if (i > 0)
                    {
                        dividend += M[i - 1, j - 1];
                        divisor++;
                    }

                    // Middle
                    dividend += M[i, j - 1];
                    divisor++;

                    // Right
                    if (i < M.GetLength(0) - 1)
                    {
                        dividend += M[i + 1, j - 1];
                        divisor++;
                    }
                }

                // Middle row

                // Left
                if (i > 0)
                {
                    dividend += M[i - 1, j];
                    divisor++;
                }

                // Mid
                dividend += M[i, j];
                divisor++;

                // Right
                if (i < M.GetLength(0) - 1)
                {
                    dividend += M[i + 1, j];
                    divisor++;
                }

                // Bottom row
                if (j < M.GetLength(1) - 1)
                {
                    // Left
                    if (i > 0)
                    {
                        dividend += M[i - 1, j + 1];
                        divisor++;
                    }

                    // Middle
                    dividend += M[i, j + 1];
                    divisor++;

                    // Right
                    if (i < M.GetLength(0) - 1)
                    {
                        dividend += M[i + 1, j + 1];
                        divisor++;
                    }
                }

                newM[i, j] = (int)Math.Floor(dividend / (double)divisor);
            }
        }

        return newM;
    }

    public int[,] ImageSmoother_Alternative(int[,] M)
    {
        int R = M.GetLength(0), C = M.GetLength(1);
        int[,] ans = new int[R, C];

        for (int r = 0; r < R; ++r)
            for (int c = 0; c < C; ++c)
            {
                int count = 0;
                for (int nr = r - 1; nr <= r + 1; ++nr)
                    for (int nc = c - 1; nc <= c + 1; ++nc)
                    {
                        if (0 <= nr && nr < R && 0 <= nc && nc < C)
                        {
                            ans[r, c] += M[nr, nc];
                            count++;
                        }
                    }
                ans[r, c] /= count;
            }

        return ans;
    }
}
