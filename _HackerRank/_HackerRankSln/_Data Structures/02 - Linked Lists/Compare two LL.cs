namespace _HackerRankSln._Data_Structures._02___Linked_Lists
{
    public static class Compare_two_LL
    {
        public static int CompareLists(Node headA, Node headB)
        {
            if (headA == null && headB == null)
            {
                return 1;
            }

            while (headA.data == headB.data)
            {
                if (headA.next == null)
                {
                    if (headB.next == null)
                    {
                        return 1;
                    }
                    else {
                        return 0;
                    }
                }

                headA = headA.next;
                headB = headB.next;
            }

            return 0;
        }
    }
}
