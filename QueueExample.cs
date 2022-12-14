using System;
using System.Collections.Generic;
namespace projects
{

    public class QueueExample
    {
        public static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            names.Enqueue("Amruth");
            names.Enqueue("Vishal");
            names.Enqueue("Jayanth");
            names.Enqueue("Rahul");
            names.Enqueue("Dheeraj");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek element: " + names.Peek());
            Console.WriteLine("Dequeue: " + names.Dequeue());
            Console.WriteLine("After Dequeue, Peek element: " + names.Peek());
        }
    }
}

