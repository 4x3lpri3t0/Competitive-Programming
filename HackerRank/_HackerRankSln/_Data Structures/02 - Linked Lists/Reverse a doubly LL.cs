using _HackerRankSln._Data_Structures._02___Linked_Lists;

// https://www.hackerrank.com/challenges/reverse-a-doubly-linked-list

public static class Reverse_a_doubly_LL
{
    public static DLLNode Reverse(DLLNode head)
    {
        if (head == null)
        {
            return null;
        }

        while (head != null)
        {
            DLLNode i = head.prev;
            head.prev = head.next;
            head.next = i;

            if (head.prev == null)
            {
                return head;
            }

            head = head.prev;
        }

        return head;
    }
}