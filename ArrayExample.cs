using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace projects
{
     class ArrayExample
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 }; 

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}

