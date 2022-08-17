/* Program to perform addition, substraction, multiplication, division, modulus division & average */


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

    class Calculation
    {

        public int Addition(int a, int b)
        {
            return a+b;
        }

        public int Difference(int c, int d)
        {
            return c - d;
        }

        public int Multiplication(int e, int f)
        {
            return e*f;
        }

        public int Division(int g, int h)
        {
            return g/h;
        }

        public int Modulus(int i, int j)
        {
            return i%j;
        }

        public double Average(double p, double q, double y)
        {
            return (p+q+y)/3;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Calculation operation = new Calculation();


            Console.WriteLine("Enter 1st number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 3rd number");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"Addition of {a} + {b} = {operation.Addition(a,b)}");
            Console.WriteLine($"Substraction of {a} - {b} = {operation.Difference(a,b)}");
            Console.WriteLine($"Multipication of {a} * {b} = {operation.Multiplication(a,b)}");
            Console.WriteLine($"Division of {a} / {b} = {operation.Division(a,b)}");
            Console.WriteLine($"Modulus division of {a} % {b} = {operation.Modulus(a,b)}");
            Console.WriteLine($"Average of {a}, {b}, {c} = {operation.Average(a,b,c)}");

            
           
        
                    

                    
                   
                
            
         
        }
    }
}