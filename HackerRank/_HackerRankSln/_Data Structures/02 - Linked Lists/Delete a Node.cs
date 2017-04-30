using _HackerRankSln._Data_Structures._02___Linked_Lists;

// https://www.hackerrank.com/challenges/delete-a-node-from-a-linked-list

public static class Delete_a_Node
{
    public static Node Delete(Node head, int position)
    {
        Node node = head;

        if (position == 0)
        {
            return node.next;
        }

        while (--position > 0)
        {
            node = node.next;
        }

        node.next = node.next.next;

        return head;
    }
}