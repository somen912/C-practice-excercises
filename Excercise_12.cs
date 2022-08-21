/* Example of method with output parameter */


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

    class Converter
    {
      public void square(int a, int b, int c, int d, out int x1, out int x2, out int x3) // method with output parameter
      {
        x1 = a+b+c+d;
        x2 = a*b*c*d;
        x3 = (a+b+c+d)/4;
        
      }

      
        
    }

    
    internal class Program
    {

        static void Main(string[] args)
        {
          int x1,x2,x3;
          int[] tom;    // declaration of array
          tom = new int[4];   // allocating memory

          Converter somen = new Converter();

          Console.WriteLine("Enter 4 numbers");  // loop for taking 4 inputs
          for(int i=0;i<4;i++)
          {
            tom[i] = int.Parse(Console.ReadLine());

          }

          
          somen.square(tom[0],tom[1],tom[2],tom[3],out x1,out x2,out x3);  // method calling with output parameter
          Console.WriteLine("\nOutput");
          Console.WriteLine($"addition = {x1}, \nMultiplication = {x2}, \nAverage = {x3}");

                   
            
         
        }
    }
}