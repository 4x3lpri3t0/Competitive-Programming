using _HackerRankSln._Data_Structures._02___Linked_Lists;

// https://www.hackerrank.com/challenges/detect-whether-a-linked-list-contains-a-cycle

public static class Cycle_Detection
{
    public static bool HasCycle(Node head)
    {
        if (head == null)
        {
            return false;
        }

        Node tortoise = head;
        Node hare = head;

        while (tortoise != null && tortoise.next != null)
        {
            tortoise = tortoise.next;
            hare = hare.next.next;

            if (hare == null || tortoise == null)
            {
                return false;
            }

            if (hare == tortoise)
            {
                return true;
            }
        }

        return false;
    }
}