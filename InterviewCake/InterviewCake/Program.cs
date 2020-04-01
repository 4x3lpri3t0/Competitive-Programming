using static InterviewCake.Questions._01___MergingMeetingTimes;
using static InterviewCake.Questions._02___ReverseStringInPlace;
using static InterviewCake.Questions._03___ReverseWordsInPlace;
using static InterviewCake.Questions._04___MergeSortedArrays;
using static InterviewCake.Questions._05___CafeOrderChecker;
using static InterviewCake.Questions._06___InflightEntertainment;
using static InterviewCake.Questions._07___PermutationPalindrome;
using static InterviewCake.Questions._08___Word_Cloud;
using static InterviewCake.Questions._09___TopScores;
using static InterviewCake.Questions._10___StockPrice;
using static InterviewCake.Questions._11___HighestProductOf3;
using static InterviewCake.Questions._12___ProductOfOtherNumbers;
using static InterviewCake.Questions._13___FindRotationPoint;
using static System.Console;

namespace InterviewCake
{
    public class Program
    {
        public static void Main()
        {
            //_01___stock_price.Main();
            //_02___product_of_other_numbers.Main();
            //_03___highest_product_of_3.Main(); // TODO: Review

            // === 2020 ===

            //MergeMeetingsTest();
            //ReverseStringInPlaceTest();
            //ReverseWordsInPlaceTest();
            //MergeSortedArrayTest();
            //IsFirstServedTest();
            //TwoMoviesOneFlightTest();
            //PermutationPalindromeTest();
            //WordCloudTest();
            //TopScoresTest();
            //GetMaxProfitTest();
            //HighestProductOf3Test(); // REVIEW
            //ProductOfOthersTest(); // REVIEW
            //FindRotationPointTest(); // REVIEW
        }

        private static void FindRotationPointTest()
        {
            string[] words = { "k", "v", "a", "b", "c", "d", "e", "g", "i" }; // 2
            int idx = FindRotationPoint(words);
            WriteLine(idx);
            string[] words2 =
            {
                "ptolemaic",
                "retrograde",
                "supplant",
                "undulate",
                "xenoepist",
                "asymptote",  // <-- rotates here (5)
                "babka",
                "banoffee",
                "engender",
                "karpatka",
                "othellolagkage",
            };
            idx = FindRotationPoint(words2);
            WriteLine(idx);
        }

        private static void ProductOfOthersTest()
        {
            int[] ints = { 1, 7, 3, 4 }; // 84, 12, 28, 21
            var result = GetProductsOfAllIntsExceptAtIndex(ints);
            WriteLine(string.Join(" ", result));
        }

        private static void HighestProductOf3Test()
        {
            int[] arrayOfInts = { 1, 10, -5, 1, -100 };
            int result = HighestProductOf3(arrayOfInts);
            WriteLine(result);
        }

        private static void GetMaxProfitTest()
        {
            int[] stockPrices = { 10, 7, 5, 8, 11, 9 };
            WriteLine(GetMaxProfit(stockPrices)); // 6
            stockPrices = new int[] { 3, 2, 1 };
            WriteLine(GetMaxProfit(stockPrices)); // 0
            stockPrices = new int[] { 1, 2, 3 };
            WriteLine(GetMaxProfit(stockPrices)); // 2
            stockPrices = new int[] { 4, 4, 4 };
            WriteLine(GetMaxProfit(stockPrices)); // 0
            stockPrices = new int[] { 0, 100 };
            WriteLine(GetMaxProfit(stockPrices)); // 100
        }

        private static void TopScoresTest()
        {
            int[] scores = { 37, 89, 41, 65, 91, 53 };
            WriteLine(string.Join(" ", GetOrderedScores(scores, 100)));
            scores = new int[] { 79, 78, 79, 78, 99, 1, 79 };
            WriteLine(string.Join(" ", GetOrderedScores(scores, 100)));
        }

        private static void WordCloudTest()
        {
            string test = "After beating the eggs, Dana read the next step:";
            PrintWordCloud(GetWordCloudDictionary(test));
            test = "Add milk and eggs, then add flour and sugar.";
            PrintWordCloud(GetWordCloudDictionary(test));
            test = "We came, we saw, we conquered...then we ate Bill's (Mille-Feuille) cake. The bill came to five dollars.";
            PrintWordCloud(GetWordCloudDictionary(test));
            test = "My name is 'h4x0r'. That is my name! h4x0r!!";
            PrintWordCloud(GetWordCloudDictionary(test));
        }

        private static void PermutationPalindromeTest()
        {
            string test = "civic";
            WriteLine(HasPalindromePermutation(test)); // True
            test = "ivicc";
            WriteLine(HasPalindromePermutation(test)); // True
            test = "civil";
            WriteLine(HasPalindromePermutation(test)); // False
            test = "livci";
            WriteLine(HasPalindromePermutation(test)); // False
        }

        private static void TwoMoviesOneFlightTest()
        {
            int flightA = 10;
            int[] moviesA = { 1, 5, 4 };
            WriteLine(TwoMoviesExist(flightA, moviesA)); // False

            int flightB = 3;
            int[] moviesB = { 1, 2 };
            WriteLine(TwoMoviesExist(flightB, moviesB)); // True

            int flightC = 1;
            int[] moviesC = { };
            WriteLine(TwoMoviesExist(flightC, moviesC)); // False
        }

        private static void IsFirstServedTest()
        {
            int[] takeOutOrders = { 1, 3, 5 };
            int[] dineInOrders = { 2, 4, 6 };
            int[] servedOrders = { 1, 2, 4, 6, 5, 3 };
            WriteLine(IsFirstComeFirstServed(takeOutOrders, dineInOrders, servedOrders));
            int[] servedOrders2 = { 1, 2, 3, 5, 4, 6 };
            WriteLine(IsFirstComeFirstServed(takeOutOrders, dineInOrders, servedOrders2));
            WriteLine(IsFirstComeFirstServed(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }));
        }

        private static void MergeSortedArrayTest()
        {
            int[] A1 = { 3, 4, 6, 10, 11, 15 };
            int[] B1 = { 1, 5, 8, 12, 14, 19 };

            // Prints [1, 3, 4, 5, 6, 8, 10, 11, 12, 14, 15, 19]
            WriteLine(string.Join(" ", MergeArrays(A1, B1)));

            int[] A2 = { 1, 2, 4, 5 };
            int[] B2 = { 3 };
            // Prints [1, 2, 3, 4, 5]
            WriteLine(string.Join(" ", MergeArrays(A2, B2)));
        }

        private static void ReverseWordsInPlaceTest()
        {
            char[] str1 = "cake pound steal".ToCharArray();
            var result = ReverseWords(str1);
            WriteLine(result);
            char[] str2 = "I am Axel".ToCharArray();
            result = ReverseWords(str2);
            WriteLine(result);
        }

        private static void ReverseStringInPlaceTest()
        {
            char[] str1 = { 'a', 'b', 'c' };
            var result = ReverseString(str1);
            WriteLine(string.Join("", result));
            char[] str2 = { 'A', 'x', 'e', 'l' };
            result = ReverseString(str2);
            WriteLine(string.Join("", result));
        }

        private static void MergeMeetingsTest()
        {
            var meeting1 = new Meeting(2, 3);  // meeting from 10:00 – 10:30 am
            var meeting2 = new Meeting(6, 9);  // meeting from 12:00 – 1:30 pm
            var meeting3 = new Meeting(9, 11);
            var meeting4 = new Meeting(10, 13);
            var meeting5 = new Meeting(11, 12);

            var meetings = new Meeting[] { meeting1, meeting2, meeting3, meeting4, meeting5 };
            MergeRanges(meetings);
        }
    }
}