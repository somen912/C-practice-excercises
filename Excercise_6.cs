﻿/* Write a program to perform the following task. 
   1. Declare two variables x and y as float type
   2. Declare m as integer variable
   3. Assign the values 75.86 to x and 43.48 to y
   4. Assign the sum of x and y to m
   5. Display the value of m */


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

    class Calculation
    {
        public double Addition(double a, double b) 
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
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            double b = Convert.ToDouble(Console.ReadLine());

            double m = operation.Addition(a,b);

           Console.WriteLine("\nOutput:");
           Console.WriteLine($"{a} + {b} = {m}");
           
        
                    

                    
                   
                
            
         
        }
    }
}