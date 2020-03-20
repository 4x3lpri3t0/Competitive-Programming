using InterviewCake.Questions;
using static InterviewCake.Questions._01___MergingMeetingTimes;

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

            var meeting1 = new Meeting(2, 3);  // meeting from 10:00 – 10:30 am
            var meeting2 = new Meeting(6, 9);  // meeting from 12:00 – 1:30 pm
            var meeting3 = new Meeting(9, 11);
            var meeting4 = new Meeting(10, 12);

            var meetings = new Meeting[] { meeting1, meeting2, meeting3, meeting4 };
            _01___MergingMeetingTimes.MergeRanges(meetings);
        }
    }
}