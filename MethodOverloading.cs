﻿using System;
namespace projects
{
    public class Cal
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    public class MethodOverloading
    {
        public static void Main()
        {
            Console.WriteLine(Cal.add(12, 23));
            Console.WriteLine(Cal.add(12, 23, 25));
        }
    }
}

