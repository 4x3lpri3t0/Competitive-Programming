using System;

namespace _HackerRankSln._Data_Structures._02___Linked_Lists
{
    public static class Print_the_Elements_of_a_LL
    {
        public static void Print(Node head)
        {
            while (head != null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }
        }
    }
}
