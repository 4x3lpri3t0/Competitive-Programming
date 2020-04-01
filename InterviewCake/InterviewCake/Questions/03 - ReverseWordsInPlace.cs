using static InterviewCake.Questions._02___ReverseStringInPlace;

namespace InterviewCake.Questions
{
    public class _03___ReverseWordsInPlace
    {
        public static char[] ReverseWords(char[] words)
        {
            words = ReverseString(words);

            // Window, beginning and end (right before space)
            int start = 0;
            int stop;

            while (start < words.Length)
            {
                stop = GetNextWhitespaceIndex(words, start);
                words = ReverseString(words, start, stop);
                start = stop + 1;
            }

            // TODO: Fix

            return words;
        }

        private static int GetNextWhitespaceIndex(char[] array, int start)
        {
            while (start < array.Length && array[start] != ' ')
            {
                start++;
            }

            // We reached the end without finding the whitespace
            return start;
        }
    }
}
