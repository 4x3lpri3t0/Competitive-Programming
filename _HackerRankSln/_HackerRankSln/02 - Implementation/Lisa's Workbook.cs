using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _HackerRankSln._02___Implementation
{
    public static class Lisa_s_Workbook
    {
        public static void PrintSpecialChapters()
        {
            int[] firstRow = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int numberOfChapters = firstRow[0];
            int maxNumOfProblemsPerPage = firstRow[1];
            int[] numberOfProblemsPerChapter = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int currentPage = 1;
            int specialProblemsCount = 0;
            for (int i = 0; i < numberOfChapters; i++)
            {
                for (int j = 1; j <= numberOfProblemsPerChapter[i]; j++)
                {
                    // Start new page? (the mod is used so we only add page on the first extra problem)
                    if (j > maxNumOfProblemsPerPage &&
                        (maxNumOfProblemsPerPage == 1 || j % maxNumOfProblemsPerPage == 1))
                    {
                        currentPage++;
                    }

                    if (j == currentPage)
                    {
                        specialProblemsCount++;
                    }
                }

                // End of chapter, new page
                currentPage++;
            }

            Console.WriteLine(specialProblemsCount);
        }
    }
}
