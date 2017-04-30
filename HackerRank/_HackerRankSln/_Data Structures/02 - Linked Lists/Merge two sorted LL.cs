using _HackerRankSln._Data_Structures._02___Linked_Lists;

// https://www.hackerrank.com/challenges/merge-two-sorted-linked-lists

public static class Merge_two_sorted_LL
{
    public static Node MergeLists(Node headA, Node headB)
    {
        if (headA == null)
        {
            return headB;
        }

        if (headB == null)
        {
            return headA;
        }

        if (headA.data < headB.data)
        {
            headA.next = MergeLists(headA.next, headB);
            return headA;
        }
        else
        {
            headB.next = MergeLists(headA, headB.next);
            return headB;
        }
    }
}