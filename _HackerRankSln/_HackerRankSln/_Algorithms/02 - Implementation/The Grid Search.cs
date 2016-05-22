using System;
using System.Text.RegularExpressions;

namespace _HackerRankSln._Algorithms._02___Implementation
{
    public static class The_Grid_Search
    {
        public static void HasPattern()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] G, P;
                GetInput(out G, out P);

                bool patternMatches = FindMatches(G, P);

                Console.WriteLine(patternMatches ? "YES" : "NO");
            }
        }

        private static bool FindMatches(string[] G, string[] P)
        {
            bool patternMatches = false;
            for (int G_r = 0; G_r < G.Length; G_r++)
            {
                string regex = "(?=" + P[0] + ")";
                var horizontalMatch = Regex.Match(G[G_r], regex);
                var nextMatchSuccess = horizontalMatch.Success;
                while (nextMatchSuccess)
                {
                    var hMatchIndx = horizontalMatch.Index;

                    bool allVerticalMatched = FindVerticalMatches(G, P, G_r, hMatchIndx);
                    if (allVerticalMatched)
                    {
                        patternMatches = true;
                        break;
                    }

                    horizontalMatch = horizontalMatch.NextMatch();
                    nextMatchSuccess = horizontalMatch.Success;
                }

                if (patternMatches)
                    break;
            }

            return patternMatches;
        }

        private static void GetInput(out string[] G, out string[] P)
        {
            string[] tokens_R = Console.ReadLine().Split(' ');
            int R = Convert.ToInt32(tokens_R[0]);
            int C = Convert.ToInt32(tokens_R[1]);
            G = new string[R];
            for (int G_i = 0; G_i < R; G_i++)
            {
                G[G_i] = Console.ReadLine();
            }
            string[] tokens_r = Console.ReadLine().Split(' ');
            int r = Convert.ToInt32(tokens_r[0]);
            int c = Convert.ToInt32(tokens_r[1]);
            P = new string[r];
            for (int P_i = 0; P_i < r; P_i++)
            {
                P[P_i] = Console.ReadLine();
            }
        }

        private static bool FindVerticalMatches(string[] G, string[] P, int G_r, int hMatchIndx)
        {
            // Next row to match
            int rowToMatch = 1;
            bool everyRowMatches = true;
            while (everyRowMatches && rowToMatch < P.Length)
            {
                // Vertical matching
                int patternRowLength = P[rowToMatch].Length;
                string G_r_substr = G[G_r + rowToMatch].Substring(hMatchIndx, patternRowLength);
                if (G_r_substr == P[rowToMatch])
                {
                    rowToMatch++;
                }
                else
                {
                    everyRowMatches = false;
                }
            }

            return everyRowMatches;
        }
    }
}
