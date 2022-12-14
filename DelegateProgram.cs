using System;
namespace projects
{
    class sample
    {
        public int getsum(int a, int b, int c)//first
        {
            return a + b + c;
        }
    }
    class DelegateProgram
    {
        delegate int sampledelegate(int a, int b, int c);//second
        static void Main(string[] args)
        {
            sample s = new sample();
            sampledelegate sd = new sampledelegate(s.getsum);//third
            Console.WriteLine("My target class name" + sd.Target);
            Console.WriteLine("my target method signature" + sd.Method);
            Console.WriteLine("Enter a value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value");
            int c = Convert.ToInt32(Console.ReadLine());
            int sum = sd.Invoke(a, b, c);//fourth
            Console.WriteLine("sum value is" + sum);
            Console.ReadLine();

        }
    }
}


