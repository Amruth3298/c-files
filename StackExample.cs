using System;
using System.Collections.Generic;
namespace projects
{
    

    public class StackExample
    {
        public static void Main(string[] args)
        {
            Stack<string> names = new Stack<string>();
            names.Push("Amruth");
            names.Push("Vishal");
            names.Push("Jayanth");
            names.Push("Rahul");
            names.Push("Dheeraj");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek element: " + names.Peek());
            Console.WriteLine("Pop: " + names.Pop());
            Console.WriteLine("After Pop, Peek element: " + names.Peek());

        }
    }

}

