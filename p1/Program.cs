using System;

namespace SwappingVariable
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            //using third variable
            int c = a;
            a = b;
            b = c;

            Console.WriteLine("After swapping a : " + a);
            Console.WriteLine("After swapping b : " +b);
        }
    }
}