using System;
using System.Collections;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queues!");

            //Creating
            Console.WriteLine("In Creating");
            Queue queue = new Queue();
            Console.WriteLine("-----------");

            //Adding
            Console.WriteLine("In Adding");
            queue.Enqueue("Calvin");
            queue.Enqueue("Tom");
            queue.Enqueue("Emma");

            foreach (var item in queue)
            {
                Console.WriteLine("Item = " + item);
            }

            Console.WriteLine("-----------");
            //Removing
            Console.WriteLine("In Removing");
            Console.WriteLine("Removing = " + queue.Dequeue());

            foreach (var item in queue)
            {
                Console.WriteLine("Item = " + item);
            }

            Console.WriteLine("-----------");
        }
    }
}
