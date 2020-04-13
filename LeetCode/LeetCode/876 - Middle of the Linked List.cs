// https://leetcode.com/problems/middle-of-the-linked-list/
public partial class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        int size = 0;
        ListNode current = head;
        while (current != null)
        {
            current = current.next;
            size++;
        }

        int mid = size / 2;
        current = head;
        for (int i = 0; i < mid; i++)
            current = current.next;

        return current;
    }
}
