using System;
namespace Projects
{
    class Program2
    {
        static int[] a = { 17, 3, 76, 98, 24 };
        static int maxnum()
        {
            int i;
            int max = a[0];
            for (i = 1; i<a.Length; i++)
                if (a[i] > max)
                max = a[i];
            return max;
        }

        public static void Main()
        {
            Console.WriteLine(" Largest number from the given array is " +maxnum());
        }
    }
}
