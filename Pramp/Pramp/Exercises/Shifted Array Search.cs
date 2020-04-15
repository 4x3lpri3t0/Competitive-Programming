// URL ???
partial class Solution
{
    static int BinarySearchShiftedArray(int[] shiftArr, int left, int right, int num)
    {

        int mid = (left + right) / 2;

        if (shiftArr[mid] == num)
        {
            return mid;
        }

        if (left >= right)
            return -1;

        int result = -1;

        bool rightHalfNotSorted = shiftArr[mid] > shiftArr[right];


        if (rightHalfNotSorted)
        {
            result = BinarySearch(shiftArr, left, mid - 1, num);

            if (result != -1)
            {
                return result;
            }

            return BinarySearchShiftedArray(shiftArr, mid + 1, right, num);
        }
        else
        {
            result = BinarySearch(shiftArr, mid + 1, right, num);  // normal 

            if (result != -1)
            {
                return result;
            }

            return BinarySearchShiftedArray(shiftArr, left, mid - 1, num);
        }
    }

    static int BinarySearch(int[] arry, int left, int right, int num)
    {

        int low = left;
        int high = right;

        while (low <= high)
        {

            int mid = left + (right - left) / 2;

            int value = arry[mid];

            if (value == num)
            {
                return mid;
            }
            else if (value < num)
            {

                low = mid - 1;
            }
            else
            {
                high = mid + 1;
            }
        }

        return -1;
    }

    public static void ShiftedArraySearch()
    {

        int[] shiftArr = { 9, 12, 17, 2, 4, 5 };
        //                  0   1   2  3   4 5
        // System.out.println(shiftedArrSearch(shiftArr, 2));

    }
}