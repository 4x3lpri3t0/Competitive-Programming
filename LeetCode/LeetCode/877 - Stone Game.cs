using System.Linq;

// https://leetcode.com/problems/stone-game/
public partial class Solution
{
    private int len;

    public bool StoneGame(int[] piles)
    {
        len = piles.Length;

        int alex = 0;
        int lee = 0;

        return Take(piles, alex, lee, 0);
    }

    bool Take(int[] piles, int alex, int lee, int i)
    {
        if (i == len)
        {
            if (alex > len)
                return true;
            else
                return false;
        }

        int[] withoutFirst = piles.Skip(1).ToArray();
        int[] withoutLast = piles.Take(len - 1).ToArray();

        if (i % 2 == 0) // Alex turn
            return Take(withoutFirst, alex + piles[0], lee, i + 1) || Take(withoutLast, alex + piles[len - 1], lee, i + 1);
        else
            return Take(withoutFirst, alex, lee + piles[0], i + 1) || Take(withoutLast, alex, lee + piles[len - 1], i + 1);
    }

    // DP Solution
    //public bool StoneGame(int[] piles)
    //{
    //    var dp = new int[piles.Length, piles.Length];

    //    for (var i = 0; i < piles.Length - 1; i++)
    //        for (var j = piles.Length - 1; j > i; j--)
    //        {
    //            var left = piles[i] - dp[i + 1, j];
    //            var right = piles[j] - dp[i, j - 1];
    //            dp[i, j] = Math.Max(left, right);
    //        }

    //    return dp[0, piles.Length - 1] > 0;
    //}
}
