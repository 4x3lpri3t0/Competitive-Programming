public class _04___MergeSortedArrays
{
    public static int[] MergeArrays(int[] A, int[] B)
    {
        int[] result = new int[A.Length + B.Length];

        // Two indexes
        int a = 0;
        int b = 0;
        int resultIndex = 0;

        // Compare until end of both arrays
        while (resultIndex < result.Length)
        {
            if (a == A.Length ||
                (b < B.Length && B[b] <= A[a]))
            {
                result[resultIndex] = B[b];
                b++;
            }
            else
            {
                result[resultIndex] = A[a];
                a++;
            }

            resultIndex++;
        }

        return result;
    }
}