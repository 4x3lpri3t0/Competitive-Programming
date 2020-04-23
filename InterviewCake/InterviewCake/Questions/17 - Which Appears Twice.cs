using System.Linq;

public class _17___Which_Appears_Twice
{
    public static long GetDuplicate(int[] numbers)
    {
        int n = numbers.Length - 1;
        int sumWithoutDuplicate = (n * n + n) / 2;
        int actualSum = numbers.Sum(x => x);

        return actualSum - sumWithoutDuplicate;
    }
}