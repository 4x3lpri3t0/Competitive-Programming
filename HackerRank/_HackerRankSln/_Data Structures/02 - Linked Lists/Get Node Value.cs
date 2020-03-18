// https://www.hackerrank.com/challenges/get-the-value-of-the-node-at-a-specific-position-from-the-tail

using _HackerRankSln._Data_Structures._02___Linked_Lists;

public static class Get_Node_Value
{
    public static int GetNode(Node head, int positionFromTail)
    {
        int nodeCount = 0;
        Node i = head;

        while (i != null)
        {
            i = i.next;
            nodeCount++;
        }

        nodeCount -= positionFromTail;

        while (--nodeCount > 0)
        {
            head = head.next;
        }

        return head.data;
    }
}