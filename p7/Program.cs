using System;

namespace MyApplication
{
    class Member
    {
        public string name = "";
        public int age;
        public long phoneNo;
        public string address = "";
        public double salary;
        public void printSalary()
        {
            Console.WriteLine("Salary is: " + salary);
        }

    }
    class Employee : Member
    {
        public string specialization = "";
      

    }

    class Manager : Member
    {
        public string department = "";
        class Program
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee();
                emp.name = "John";
                emp.age = 25;
                emp.phoneNo = 98056473736;
                emp.address = "London";
                emp.salary = 25000;
                emp.specialization = "Expert";
                Console.WriteLine(emp.name);
                Console.WriteLine(emp.age);
                Console.WriteLine(emp.phoneNo);
                Console.WriteLine(emp.address);
                emp.printSalary();

                Manager mng = new Manager();
                mng.name = "Jack";
                mng.age = 18;
                mng.phoneNo = 90747848843;
                mng.address = "Australia";
                mng.salary = 35000;
                mng.department = "Admin";
                Console.WriteLine(mng.name);
                Console.WriteLine(mng.age);
                Console.WriteLine(mng.phoneNo);
                Console.WriteLine(mng.address);
                Console.WriteLine(mng.salary);
                Console.ReadLine();
            }
        }
    }
}