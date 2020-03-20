using InterviewCake.Questions;
using System;
using static InterviewCake.Questions._01___MergingMeetingTimes;
using static InterviewCake.Questions._02___ReverseStringInPlace;
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

            //MergeMeetings();
            //ReverseString();
            //ReverseWordsInPlace();
        }

        private static void ReverseWordsInPlace()
        {
            char[] str1 = "cake pound steal".ToCharArray();
            var result = _03___ReverseWordsInPlace.ReverseWords(str1);
            WriteLine(result);
        }

        private static void ReverseStringInPlace()
        {
            char[] str1 = { 'a', 'b', 'c' };
            var result = ReverseString(str1);
            WriteLine(string.Join("", result));
            char[] str2 = { 'A', 'x', 'e', 'l' };
            result = ReverseString(str2);
            WriteLine(string.Join("", result));
        }

        private static void MergeMeetings()
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