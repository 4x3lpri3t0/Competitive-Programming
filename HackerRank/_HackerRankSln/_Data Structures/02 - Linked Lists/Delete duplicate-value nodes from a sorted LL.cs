using _HackerRankSln._Data_Structures._02___Linked_Lists;

// https://www.hackerrank.com/challenges/delete-duplicate-value-nodes-from-a-sorted-linked-list

public static class Delete_duplicate_value_nodes_from_a_sorted_LL
{
    public static Node RemoveDuplicates(Node head)
    {
        Node node = head;

        if (head == null)
        {
            return null;
        }

        while (head.next != null)
        {
            if (head.data == head.next.data)
            {
                head.next = head.next.next;
            }
            else
            {
                head = head.next;
            }
        }

        return node;
    }
}