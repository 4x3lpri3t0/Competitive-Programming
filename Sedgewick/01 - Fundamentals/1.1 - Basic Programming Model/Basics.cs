using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1___Basic_Programming_Model
{
    class Basics
    {
        public static int MaximumOfArrayValues(int[] intArray)
        {
            int max = intArray[0];

            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > max) max = intArray[i];
            }

            return max;
        }

        public static double AverageOfArrayValues(double[] dArray)
        {
            double sum = 0;
            double average;

            for (int i = 0; i < dArray.Length; i++)
            {
                sum += dArray[i];
            }

            average = sum / dArray.Length;

            return average;
        }

        
        public static string[] CopyToAnotherArray(string[] oldArray)
        {
            string[] newArray = new string[oldArray.Length];

            for (int i = 0; i < oldArray.Length; i++)
			{
                newArray[i] = oldArray[i];
			}

            return newArray;
        }

        
        public static double[] ReverseArray(double[] array)
        {
            int arrayLength = array.Length;

            for (int i = 0; i < arrayLength/2; i++)
            {
                double temp = array[i];
                array[i] = array[arrayLength - 1 - i];
                array[arrayLength - i - 1] = temp;
            }

            return array;
        }

        public static int AbsoluteValueOfInt(int x)
        {
            if (x < 0) return -x;
            else       return  x;
        }

        
        public static bool IsPrime(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
                
    }
}
