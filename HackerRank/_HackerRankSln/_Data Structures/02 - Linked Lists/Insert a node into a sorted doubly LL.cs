using _HackerRankSln._Data_Structures._02___Linked_Lists;

// https://www.hackerrank.com/challenges/insert-a-node-into-a-sorted-doubly-linked-list

public static class Insert_a_node_into_a_sorted_doubly_LL
{
    public static Node2 SortedInsert(Node2 head, int data)
    {
        Node2 node = head;
        if (node == null)
        {
            node = new Node2();
            node.data = data;
            return node;
        }
        while (node != null)
        {
            if (node.data >= data)
            {
                Node2 i = new Node2();
                i.data = data;
                i.prev = node.prev;
                i.next = node;
                node.prev = i;
                if (i.prev == null)
                {
                    return i;
                }
                else
                {
                    i.prev.next = i;
                    return head;
                }
            }
            if (node.next == null)
            {
                Node2 i = new Node2();
                i.data = data;
                i.prev = node;
                i.next = null;
                node.next = i;
                break;
            }
            node = node.next;
        }
        return head;
    }
}