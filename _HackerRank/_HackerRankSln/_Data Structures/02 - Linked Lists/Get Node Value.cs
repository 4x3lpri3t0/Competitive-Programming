namespace _HackerRankSln._Data_Structures._02___Linked_Lists
{
    public static class Get_Node_Value
    {
        public static int GetNode(Node head, int n)
        {
            int nodes = 0;
            Node i = head;

            while (i != null)
            {
                i = i.next;
                nodes++;
            }

            nodes -= n;

            while (--nodes > 0)
            {
                head = head.next;
            }

            return head.data;
        }
    }
}
