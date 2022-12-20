using System;
namespace projects
{
    class NullableExample2
    {
        static void Main(string[] args)
        {
             
            int? a = 10;
             
            double? f = 10.10;
           
            bool? b = false;
            
            char? c = 'S';
           
            if (a.HasValue)
            {
                Console.WriteLine(a.Value);
            }
            else Console.WriteLine("a contains null value");

            a = null;
            if (a.HasValue) 
            {
                Console.WriteLine(a.Value);
            }
            else Console.WriteLine("a contains null value");
        }
    }

}

