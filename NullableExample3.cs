using System;
namespace projects
{
    class NullableExample3
    {
        static void Main(string[] args)
        {
            Nullable<int> a = 10;
            Nullable<double> d = 10.10;
            Nullable<char> c = 'S';
            Nullable<bool> b = false;
           
            Console.WriteLine(a.Value);
            a = null;
            d = null;
            c = null;
            b = null;

            if (a.HasValue)
            {
                Console.WriteLine(a.Value);
            }
            if (a == null)
                Console.WriteLine("It contains null value");
        }
    }

}

