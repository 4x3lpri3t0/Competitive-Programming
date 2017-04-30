using _HackerRankSln._Data_Structures._02___Linked_Lists;
using System;

// https://www.hackerrank.com/challenges/print-the-elements-of-a-linked-list

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