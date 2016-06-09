using System;
using System.Collections.Generic;

namespace _HackerRankSln._Data_Structures._05___Stacks
{
    public static class Largest_Rectangle
    {
        public static void Main()
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] hist = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine(GetMaxArea(hist, size));
        }

        static int GetMaxArea(int[] hist, int N)
        {
            var stack = new Stack<int>();
            int maxArea = 0;
            int topItem;        // To store top of stack
            int areaWithTop;    // To store area with top bar as the smallest bar

            // Run through all bars of given histogram
            int i = 0;
            while (i < N)
            {
                // If this bar is higher than the bar on top stack, push it to stack
                if (stack.Count == 0 || hist[stack.Peek()] <= hist[i])
                {
                    stack.Push(i++);
                }
                // If this bar is lower than top of stack, then calculate area of rectangle 
                // with stack top as the smallest (or minimum height) bar. 'i' is 
                // 'right index' for the top and element before top in stack is 'left index'
                else
                {
                    topItem = stack.Pop(); // store the top index
                    
                    // Calculate the area with hist[tp] stack as smallest bar
                    areaWithTop = hist[topItem] * (stack.Count == 0 ? i : i - stack.Peek() - 1);

                    // update max area, if needed
                    if (maxArea < areaWithTop)
                        maxArea = areaWithTop;
                }
            }

            // Now pop the remaining bars from stack and calculate area with every
            // popped bar as the smallest bar
            while (stack.Count != 0)
            {
                topItem = stack.Pop();
                areaWithTop = hist[topItem] * (stack.Count == 0 ? i : i - stack.Peek() - 1);

                if (maxArea < areaWithTop)
                    maxArea = areaWithTop;
            }

            return maxArea;
        }
    }
}
