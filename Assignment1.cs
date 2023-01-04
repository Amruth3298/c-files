using System;
namespace Projects
{
    class Assignment1
    {
        static int Divisible(int num1, int num2)
        {
            return (num1 % 2 == 0 && num2 % 2 == 0 || num1 % 3 == 0 && num2 % 3 == 0) ?
                num1 * num2 : num1 + num2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Divisible(12, 6));
            Console.WriteLine(Divisible(5, 7));
        }
    }
}

