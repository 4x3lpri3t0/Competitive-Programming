namespace _HackerRankSln._Data_Structures._02___Linked_Lists
{
    class Insert_a_node_at_a_specific_position_in_a_linked_list
    {
        public static Node1 InsertNth(Node1 head, int data, int position)
        {
            Node1 node = head;
            if (position == 0)
            {
                node = new Node1();
                node.data = data;
                node.next = head;

                return node;
            }
            else
            {
                while (--position > 0)
                {
                    node = node.next;
                }

                Node1 i = node.next;
                node.next = new Node1() { data = data, next = i };

                return head;
            }
        }
    }
}
