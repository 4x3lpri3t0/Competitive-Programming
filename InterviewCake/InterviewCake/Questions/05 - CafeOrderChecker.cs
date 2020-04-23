public class _05___CafeOrderChecker
{
    public static bool IsFirstComeFirstServed(int[] aOrders, int[] bOrders, int[] servedOrders)
    {
        int a = 0;
        int b = 0;
        int servedIdx = 0;

        if (servedOrders.Length != aOrders.Length + bOrders.Length)
        {
            return false;
        }

        while (a < aOrders.Length || b < bOrders.Length)
        {
            if (a < aOrders.Length &&
                (aOrders[a] == servedOrders[servedIdx]))
            {
                a++;
            }
            else if (b < bOrders.Length &&
              (bOrders[b] == servedOrders[servedIdx]))
            {
                b++;
            }
            else
            {
                return false;
            }

            servedIdx++;
        }

        return true;
    }
}
