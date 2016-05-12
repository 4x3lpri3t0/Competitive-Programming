using System;

namespace _HackerRankSln._01___Warmup_Problems
{
    public static class Time_Conversion
    {
        public static void ConvertTime()
        {
            string time = Console.ReadLine();

            bool isAm = time.Contains("AM");

            int hours = int.Parse(time.Substring(0, 2));
            if (isAm)
            {
                if (hours == 12)
                {
                    time = ReplaceHours(time, "00");
                }
            }
            else
            {
                if (hours != 12)
                {
                    hours += 12;
                }

                time = ReplaceHours(time, hours.ToString());
            }

            // Remove AM / PM
            time = time.Remove(time.Length - 2, 2);

            Console.WriteLine(time);
        }

        private static string ReplaceHours(string timeStr, string hours)
        {
            timeStr = timeStr.Remove(0, 2);
            timeStr = hours + timeStr;

            return timeStr;
        }
    }
}
