/* Write a progrme to add all the odd numbers from 0 to 20. Use a simple if and goto statement */


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

    class Converter
    {

      public double OddChecker(double number)
      {
        double sum = 0;
        
        for(int i=0; i<=number ; i++)
        {

          if(i%2==0)
          {
            goto odd;
          }

          odd:
          i+=1;
          sum += i;

        }

        return sum;      
      }
        
    }

    
    internal class Program
    {

        static void Main(string[] args)
        {
           
           Converter somen = new Converter();

           Console.WriteLine("Enter number");
           double user = double.Parse(Console.ReadLine());

           Console.WriteLine($"{somen.OddChecker(user)}");

                   
            
         
        }
    }
}