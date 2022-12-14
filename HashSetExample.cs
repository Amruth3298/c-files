using System;
using System.Collections.Generic;
namespace projects
{
    

    public class HashSetExample
    {
        public static void Main(string[] args)
        {
            var names = new HashSet<string>();
            names.Add("Amruth");
            names.Add("Vishal");
            names.Add("Jayanth");
            names.Add("Rahul");
            names.Add("Dheeraj"); 
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}

