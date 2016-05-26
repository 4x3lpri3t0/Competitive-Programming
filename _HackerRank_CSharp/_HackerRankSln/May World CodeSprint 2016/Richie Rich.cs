using System;
using System.Collections.Generic;
using System.Linq;

namespace _HackerRankSln.May_World_CodeSprint_2016
{
    public static class Richie_Rich
    {
        public static void PrintMaxPalindrome()
        {
            int[] firstRow = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            string originalNStr = Console.ReadLine();
            char[] originalNCharArray = originalNStr.ToCharArray();
            int nDigits = firstRow[0];
            int k = firstRow[1];

            int maxPalindrome = -1;
            if (IsPalindrome(originalNStr))
            {
                maxPalindrome = int.Parse(originalNStr);
            }

            var incompatibleIndxs = GetIncompatibleIndexes(originalNStr);

            foreach (var indx in incompatibleIndxs)
            {
                if (k >= 2)
                {
                    originalNCharArray[indx.Key] = '9';
                    originalNCharArray[nDigits - indx.Key - 1] = '9';
                    k -= 2;
                }
                else if (k == 1)
                {
                    // Choose better of 2 and replace the other index
                    if (indx.Value[0] > indx.Value[1])
                    {
                        originalNCharArray[nDigits - indx.Key - 1] = indx.Value[0];
                        k--;
                    }
                    else if (indx.Value[1] > indx.Value[0])
                    {
                        originalNCharArray[indx.Key] = indx.Value[1];
                        k--;
                    }
                }
                else // k == 0
                {
                    break;
                }
            }

            // If I have no more incompatibles:
            int i = 0;
            while (k > 0)
            {
                if (originalNCharArray[i] != '9')
                {
                    if (k > 1)
                    {
                        originalNCharArray[i] = '9';
                        originalNCharArray[nDigits - i - 1] = '9';
                        k -= 2;
                    }
                    else // k == 1
                    {
                        // Choose better of 2 and replace the other index
                        if (originalNCharArray[i] > originalNCharArray[nDigits - i - 1])
                        {
                            originalNCharArray[nDigits - i - 1] = originalNCharArray[i];
                            k--;
                        }
                        else if (originalNCharArray[i] < originalNCharArray[nDigits - i - 1])
                        {
                            originalNCharArray[i] = originalNCharArray[nDigits - i - 1];
                            k--;
                        }
                    }
                }

                i++;
            }

            string newString = new string(originalNCharArray);
            if (IsPalindrome(newString))
            {
                int newStrInt = int.Parse(newString);
                if (newStrInt > maxPalindrome)
                {
                    maxPalindrome = newStrInt;
                }
            }

            Console.WriteLine(maxPalindrome);
        }

        private static bool IsPalindrome(string original)
        {
            var incompatibleIndxs = GetIncompatibleIndexes(original);

            return incompatibleIndxs.Count == 0;
        }

        // Key: Index, Value: Value
        private static SortedDictionary<int, char[]> GetIncompatibleIndexes(string original)
        {
            var incompatibles = new SortedDictionary<int, char[]>();
            int strMiddle = original.Length / 2;
            string reversed = new string(original.Reverse().ToArray());
            string half1 = original.Substring(0, strMiddle);
            string half2 = reversed.Substring(0, strMiddle);

            for (int i = 0; i < strMiddle; i++)
            {
                if (half1[i] != half2[i])
                {
                    var dictValues = new char[] { half1[i], half1[i] };
                    incompatibles.Add(i, dictValues);
                }
            }

            return incompatibles;
        }
    }
}
