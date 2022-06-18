using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1___Basic_Programming_Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GreatestCommonDivisor.GCD(10, 6));

            Console.WriteLine(Basics.MaximumOfArrayValues(new int[] {1, 2, 3, 4}));

            Console.WriteLine(Basics.AverageOfArrayValues(new double[] {10, 20, 30}));

            var originalArray = new string[] {"copy", "this", "please"};
            var copyArray = Basics.CopyToAnotherArray(originalArray);
            Console.WriteLine(string.Join(",", copyArray));

            var reversedArray = Basics.ReverseArray(new double[] { 3, 2, 1 });
            Console.WriteLine(string.Join(",",reversedArray));

            Console.WriteLine(Basics.AbsoluteValueOfInt(-30));

            Console.WriteLine("Is 13 prime? : " + Basics.IsPrime(13));
            Console.WriteLine("Is 10 prime? : " + Basics.IsPrime(10));
        }
    }
}
