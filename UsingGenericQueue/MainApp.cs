using System;
using System.Collections.Generic;

namespace UsingGenericQueue
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < 5; i++)
            {
                queue.Enqueue(i);
            }
            foreach (int que in queue)
            {
                Console.Write($"{que} ");
            }

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                queue.Dequeue();
            }
            foreach (int que in queue)
            {
                Console.Write($"{que} ");
            }
        }
    }
}
