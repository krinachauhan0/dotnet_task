﻿using System;

namespace MyApplication
{
     class LaptopBase                           
    {
        public const string Name1 = "Dell";
        public const string Name2 = "HP";
        public const string Name3 = "Lenovo";
        public const string Name4 = "Acer";

        public const string Price1 = "$1500";
        public const string Price2 = "$1200";
        public const string Price3 = "$1000";
        public const string Price4 = "$1800";

        public const string Processor1 = "i5";
        public const string Processor2 = "i3";
        public const string Processor3 = "i7";
        public const string Processor4 = "i9";

        public const string RAM1 = "4GB";
        public const string RAM2 = "8GB";
        public const string RAM3 = "2GB";
        public const string RAM4 = "16GB";

        public const string HDD1 = "1TB";
        public const string HDD2 = "2TB";
        public const string HDD3 = "500GB";
        public const string HDD4 = "1TB";
            
    }

    class Laptop : LaptopBase                    
    {
        public void LaptopDetails(string name, string price, string processor, string ram, string hdd)
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Price : " + price);
            Console.WriteLine("Processor : " + processor);
            Console.WriteLine("RAM : " + ram);
            Console.WriteLine("HDD : " + hdd);

        }

    }
    class Program
    {
        static void Main (string[] args)
        {
            Laptop myLaptop = new Laptop();
            myLaptop.LaptopDetails(Laptop.Name1, Laptop.Price1, Laptop.Processor1, Laptop.RAM1, Laptop.HDD1);
            Console.WriteLine();
            myLaptop.LaptopDetails(Laptop.Name2, Laptop.Price2, Laptop.Processor2, Laptop.RAM2, Laptop.HDD2);
            Console.WriteLine();
            myLaptop.LaptopDetails(Laptop.Name3, Laptop.Price3, Laptop.Processor3, Laptop.RAM3, Laptop.HDD3);
            Console.WriteLine();
            myLaptop.LaptopDetails(Laptop.Name4, Laptop.Price4, Laptop.Processor4, Laptop.RAM4, Laptop.HDD4);
            Console.WriteLine();
            
        }
    
    }
}