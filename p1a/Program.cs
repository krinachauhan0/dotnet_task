using System;

namespace SwappingVariable
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            //without using third variable
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After swapping a : " + a);
            Console.WriteLine("After swapping b : " +b);
        }
    }
}