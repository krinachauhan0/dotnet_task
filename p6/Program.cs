﻿using System;

namespace InheritanceExample
{
    class ParentClass                       
    {
        public void Method1()         
        {
            Console.WriteLine("This is parent class");
        }

    }

    class SubClass : ParentClass               
    {
        public void Method2()          
        {
            Console.WriteLine("This is child class");
        }
      
    }

    class Program
    {
        static void Main (string[] args)
        {
            ParentClass parentClass = new ParentClass();      
            SubClass subClass = new SubClass();      
            parentClass.Method1();                
            subClass.Method2();                
            subClass.Method1();                
        }
    }


}