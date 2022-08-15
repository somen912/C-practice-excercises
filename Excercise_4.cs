/* Write a program that assigns two values to two variables, computes their sum, assigns the result to a third variable and display
   all the three values in one line of output */


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Calculation
    {
        public int addition (int a, int b)
        {
           return a+b;
        }

    }

   

    internal class Program
    {

        static void Main(string[] args)
        {
            Calculation operation = new Calculation();

           Console.WriteLine("Enter 1st number");
           int a = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter 2nd number");
           int b = Convert.ToInt32(Console.ReadLine());

           int c = operation.addition(a,b);

           Console.WriteLine("\nOutput:");
           Console.WriteLine($"{a} + {b} = {c}");

         
        }
    }
}