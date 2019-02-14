using System;

// https://leetcode.com/problems/middle-of-the-linked-list/
public partial class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        int counter = 1;
        ListNode iterator = head;
        while (iterator.next != null)
        {
            counter++;
            iterator = iterator.next;
        }

        int middle = (counter / 2) + 1;
        for (int i = 1; i < middle; i++)
        {
            head = head.next;
        }

        return head;
    }
}
