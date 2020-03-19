using _HackerRankSln._Data_Structures._02___Linked_Lists;

// https://www.hackerrank.com/challenges/insert-a-node-into-a-sorted-doubly-linked-list

public static class Insert_a_node_into_a_sorted_doubly_LL
{
    public static DLLNode SortedInsert(DLLNode head, int data)
    {
        var node = head;
        var newNode = new DLLNode(data);
        if (node == null)
        {
            return newNode;
        }

        while (node != null)
        {
            if (node.data >= data)
            {
                newNode.prev = node.prev;
                newNode.next = node;
                node.prev = newNode;
                if (newNode.prev == null)
                {
                    return newNode;
                }
                else
                {
                    newNode.prev.next = newNode;
                    return head;
                }
            }

            if (node.next == null)
            {
                newNode.prev = node;
                newNode.next = null;
                node.next = newNode;
                return head;
            }

            node = node.next;
        }
        return head;
    }
}