namespace _HackerRankSln._Data_Structures._02___Linked_Lists
{
    public static class Insert_a_Node_at_the_Tail_of_a_Linked_List
    {
        public static Node1 InsertTail(Node1 head, int data)
        {
            if (head == null)
            {
                head = new Node1();
                head.data = data;
            }
            else
            {
                Node1 node = head;
                while (node.next != null)
                {
                    node = node.next;
                }
                node.next = new Node1();
                node.next.data = data;
            }

            return head;
        }
    }
}
