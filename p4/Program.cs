using System; 

namespace FibonacciExample
{
   class Program  
   {  
     public static void Main(string[] args)  
      {  
         int no1 = 0, no2 = 1, no3, i, number;    
         Console.Write("Enter the number of elements: ");    
         number = Convert.ToInt32(Console.ReadLine());  
         Console.WriteLine(no1+" "+no2+" "); //printing 0 and 1    
         for(i = 2; i < number; i++) //loop starts from 2 because 0 and 1 are already printed    
         {    
          no3 = no1 + no2;    
          Console.WriteLine(no3 + " ");    
          no1 = no2;    
          no2 = no3;    
         }    
      }  
   } 
} 