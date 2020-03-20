using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake.Questions
{
    public class _02___ReverseStringInPlace
    {
        public static char[] ReverseString(char[] array, int start = 0, int stop = -1)
        {
            stop = stop >= 0 ? stop : array.Length;

            // Replace first with last, until middle
            for (int i = start; i < stop / 2; i++)
            {
                char first = array[i];
                char last = array[stop - 1 - i];

                array[i] = last;
                array[stop - 1 - i] = first;
            }

            return array;
        }
    }
}
