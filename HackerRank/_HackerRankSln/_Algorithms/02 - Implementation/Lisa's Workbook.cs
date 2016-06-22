using System;

namespace _HackerRankSln._Algorithms._02___Implementation
{
    public static class Lisa_s_Workbook
    {
        public static void PrintSpecialChapters()
        {
            int numberOfChapters, maxNumOfProblemsPerPage;
            int[] numberOfProblemsPerChapter;
            GetInput(out numberOfChapters, out maxNumOfProblemsPerPage, out numberOfProblemsPerChapter);

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

        private static void GetInput(out int numberOfChapters, out int maxNumOfProblemsPerPage, out int[] numberOfProblemsPerChapter)
        {
            int[] firstRow = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            numberOfChapters = firstRow[0];
            maxNumOfProblemsPerPage = firstRow[1];
            numberOfProblemsPerChapter = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        }
    }
}
