using System;
using System.Collections.Generic;
using System.Linq;

namespace _HackerRankSln.Competitions.Zalando_CodeSprint
{
    public static class The_Inquiring_Manager
    {
        public struct Order
        {
            public long? price;
            public long time;

            public Order(long T, long P)
            {
                price = P;
                time = T;
            }
        }

        public static void _Main()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            var queue = new Queue<Order>();
            string output = "";
            while (N-- != 0)
            {
                long[] input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
                int type = (int)input[0];
                if (type == 1)
                {
                    // Insert order
                    long P = input[1];
                    long T = input[2];
                    queue.Enqueue(new Order(T, P));
                }
                else
                {
                    // Enquiry
                    long T = input[1];

                    queue = RemoveOldOrdersFromQueue(queue, T);

                    long? max = queue.Select(x => x.price)
                                     .Max();
                    max = max == null ? max = -1 : max;
                    output += output == "" ? max.Value.ToString() : "\n" + max.Value;
                }
            }
            Console.WriteLine(output);
        }

        private static Queue<Order> RemoveOldOrdersFromQueue(Queue<Order> queue, long T)
        {
            return new Queue<Order>(queue.Where(o => o.time >= (T - 59)));
        }
    }
}
