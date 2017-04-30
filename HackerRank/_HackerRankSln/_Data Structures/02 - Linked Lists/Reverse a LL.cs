using _HackerRankSln._Data_Structures._02___Linked_Lists;

// https://www.hackerrank.com/challenges/reverse-a-linked-list

public static class Reverse_a_LL
{
    public static Node Reverse(Node head)
    {
        if (head == null)
        {
            return null;
        }

        Node node = null;

        while (head != null)
        {
            Node i = node;
            node = new Node();
            node.data = head.data;
            node.next = i;
            head = head.next;
        }

        return node;
    }
}