using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCake.Questions
{
    public class _01___MergingMeetingTimes
    {
        public class Meeting
        {
            public int StartTime { get; set; }

            public int EndTime { get; set; }

            public Meeting(int startTime, int endTime)
            {
                // Number of 30 min blocks past 9:00 am
                StartTime = startTime;
                EndTime = endTime;
            }

            public override string ToString()
            {
                return $"({StartTime}, {EndTime})";
            }
        }

        public static void MergeRanges(Meeting[] meetings)
        {
            var mergedMeetings = new List<Meeting>();

            // Order meetings by Start Time
            meetings = meetings
                .OrderBy(x => x.StartTime)
                .ToArray();

            var lastMeeting = meetings[0];
            for (int i = 1; i < meetings.Length; i++)
            {
                var currentMeeting = meetings[i];

                if (lastMeeting.EndTime >= currentMeeting.StartTime)
                {
                    // Merge
                    lastMeeting.EndTime = Math.Max(lastMeeting.EndTime, currentMeeting.EndTime);
                }
                else
                {
                    mergedMeetings.Add(lastMeeting);
                    lastMeeting = currentMeeting;
                }
            }

            // Add last one
            mergedMeetings.Add(lastMeeting);

            // Output
            foreach (var mergedMeeting in mergedMeetings)
            {
                Console.WriteLine(mergedMeeting);
            }
        }
    }
}
