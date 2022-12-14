using System;
using System.Collections.Generic;
namespace projects
{

    public class DictionaryExample
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("1", "Amruth");
            names.Add("2", "Vishal");
            names.Add("3", "Jayanth");
            names.Add("4", "Rahul");
            names.Add("5", "Dheeraj");

            foreach (KeyValuePair<string, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
}

