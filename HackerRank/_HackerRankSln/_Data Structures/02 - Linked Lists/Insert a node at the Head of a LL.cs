using _HackerRankSln._Data_Structures._02___Linked_Lists;

// https://www.hackerrank.com/challenges/insert-a-node-at-the-head-of-a-linked-list

public static class Insert_a_node_at_the_Head_of_a_LL
{
    public static Node InsertHead(Node head, int data)
    {
        Node node = new Node();
        node.data = data;
        node.next = head;

        return node;
    }
}