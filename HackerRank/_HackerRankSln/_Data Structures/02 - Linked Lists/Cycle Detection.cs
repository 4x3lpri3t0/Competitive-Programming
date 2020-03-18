using _HackerRankSln._Data_Structures._02___Linked_Lists;

// https://www.hackerrank.com/challenges/detect-whether-a-linked-list-contains-a-cycle

public static class Cycle_Detection
{
    public static bool HasCycle(Node head)
    {
        if (head == null)
            return false;

        Node tortoise = head;
        Node hare = head.next;

        while (tortoise != null && hare != null)
        {
            if (hare == tortoise)
                return true;

            if (hare.next == null)
                return false;

            tortoise = tortoise.next;
            hare = hare.next.next;
        }

        return false;
    }
}