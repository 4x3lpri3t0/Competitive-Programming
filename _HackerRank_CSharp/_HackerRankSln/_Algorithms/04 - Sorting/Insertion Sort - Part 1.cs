using System;

namespace _HackerRankSln._Algorithms._04___Sorting
{
    public static class Insertion_Sort___Part_1
    {
        public static void insertionSort()
        {
            int _ar_size;
            _ar_size = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[_ar_size];
            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');
            for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
            {
                ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
            }

            int rightmost = ar[ar.Length - 1];
            for (int i = ar.Length - 2; i >= 0; i--)
            {
                if (ar[i] > rightmost)
                {
                    ar[i + 1] = ar[i];
                    Console.WriteLine(string.Join(" ", ar));
                }
                else
                {
                    ar[i + 1] = rightmost;
                    Console.WriteLine(string.Join(" ", ar));
                    break;
                }

                // If it's the lowest element, assign rightmost
                if (i == 0)
                {
                    ar[i] = rightmost;
                    Console.WriteLine(string.Join(" ", ar));
                }
            }
        }
    }
}
