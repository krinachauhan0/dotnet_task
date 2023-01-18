using System;

namespace MyApplication
{
    class Rectangle
    {
        public int length, breadth;

        public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public void printArea()
        {
            Console.WriteLine("Area of a rectangle : " + (length * breadth));
        }

        public void printPerimeter()
        {
            Console.WriteLine("Perimeter of a rectangle : " + 2 * (length + breadth));
        }

    }

    class Square : Rectangle
    {
        int s;
        public Square(int length, int breadth) : base(length, breadth)
        {
            this.s = length;
            printArea();
            printPerimeter();

        }

        public void printAreaS()
        {
            Console.WriteLine("Area of a Square : " + Math.Pow(s,2));
        }

        public void printPerimeterS()
        {
            Console.WriteLine("Perimeter of a Square : " + 2 * length);
        }
    }
    class Manager
    {
        class Program
        {
            static void Main(string[] args)
            {
                Square square = new Square(10,20);
                square.printAreaS();
                square.printPerimeterS();
            }
        }
    }
}
