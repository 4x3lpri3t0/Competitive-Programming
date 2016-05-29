namespace _HackerRankSln._Data_Structures._02___Linked_Lists
{
    public static class Insert_a_node_at_the_head_of_a_linked_list
    {
        public static Node1 InsertHead(Node1 head, int data)
        {
            Node1 node = new Node1();
            node.data = data;
            node.next = head;

            return node;
        }
    }
}
