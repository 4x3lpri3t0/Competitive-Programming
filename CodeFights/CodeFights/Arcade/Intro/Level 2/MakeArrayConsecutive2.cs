using System;
using System.Linq;

// https://codefights.com/arcade/intro/level-2/bq2XnSr5kbHqpHGJC

public class MakeArrayConsecutive2
{
    public static void Main()
    {
        Console.WriteLine(makeArrayConsecutive2(new int[] { 6, 2, 3, 8 }));
    }

    private static int makeArrayConsecutive2(int[] statues)
    {
        int min = statues.Min();
        int max = statues.Max();

        return max - min - statues.Length + 1;
    }
}