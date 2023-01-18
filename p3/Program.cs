using System;

namespace FactorialNumber
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;

            }
            Console.WriteLine("Factorial number is : "  + fact);
			Console.ReadLine();
        }

    }
}