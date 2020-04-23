public class _16___Find_Unique_Int_Among_Duplicates
{
    public static int FindUniqueInteger(int[] arr)
    {
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum ^= arr[i];
        }

        return sum;
    }
}