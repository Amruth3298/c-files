using System;
namespace AccessSpecifiers
{
    class PublicTest
    {
        public string name = "Amruth";
        public void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            PublicTest publicTest = new PublicTest();
           
            Console.WriteLine("Hello " + publicTest.name);
             
            publicTest.Msg("welcome");
        }
    }
}
