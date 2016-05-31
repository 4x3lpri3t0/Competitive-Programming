namespace _HackerRankSln._Data_Structures._02___Linked_Lists
{
    public static class Reverse_a_doubly_LL
    {
        public static Node2 Reverse(Node2 head)
        {
            if (head == null)
            {
                return null;
            }

            while (head != null)
            {
                Node2 i = head.prev;
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
}
