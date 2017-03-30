using System;
using System.Linq;

namespace InterviewCake.Questions
{
    public class _02___product_of_other_numbers
    {
        public static void Main()
        {
            int[] ints = { 1, 7, 3, 4 };
            var result = GetProductsOfAllIntsExceptAtIndex(ints);
            Console.WriteLine(string.Join(" ", result));
        }

        private static int[] GetProductsOfAllIntsExceptAtIndex(int[] nums)
        {
            int[] otherProds = new int[nums.Length];

            // Find products before (left) current
            int prodSoFar = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                otherProds[i] = prodSoFar;
                prodSoFar *= nums[i];
            }

            // Find products after (right) current
            prodSoFar = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                otherProds[i] *= prodSoFar;
                prodSoFar *= nums[i];
            }

            return otherProds;
        }
    }
}