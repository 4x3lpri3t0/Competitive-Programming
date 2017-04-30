using _HackerRankSln._Data_Structures._02___Linked_Lists;

// https://www.hackerrank.com/challenges/insert-a-node-at-the-tail-of-a-linked-list

public static class Insert_a_Node_at_the_Tail_of_a_LL
{
    public static Node InsertTail(Node head, int data)
    {
        if (head == null)
        {
            head = new Node();
            head.data = data;
        }
        else
        {
            Node node = head;
            while (node.next != null)
            {
                node = node.next;
            }
            node.next = new Node();
            node.next.data = data;
        }

        return head;
    }
}