namespace _HackerRankSln._Data_Structures._02___Linked_Lists
{
    class Insert_a_node_at_a_specific_position_in_a_LL
    {
        public static Node InsertNth(Node head, int data, int position)
        {
            Node node = head;
            if (position == 0)
            {
                node = new Node();
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

                Node i = node.next;
                node.next = new Node() { data = data, next = i };

                return head;
            }
        }
    }
}
