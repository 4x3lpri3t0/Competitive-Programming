namespace InterviewCake.Questions
{
    public class _02___ReverseStringInPlace
    {
        public static char[] ReverseString(char[] array, int start = 0, int stop = -1)
        {
            stop = stop >= 0 ? stop : array.Length;

            int mid = start + ((stop - start) / 2);
            // Replace first with last, until middle
            for (int i = start; i < mid; i++)
            {
                int end = start + stop - 1 - i;

                char first = array[i];
                char last = array[end];

                array[i] = last;
                array[end] = first;
            }

            return array;
        }
    }
}
