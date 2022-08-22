/* Example of variable argument list using params */


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

    class Converter
    {
      public double Average_function(params double[] avg) 
      {
        double sum=0;

        foreach(int i in avg)
        {
          sum+=i;

        }

        return sum/avg.Length;
        
        
      }

      
        
    }

    
    internal class Program
    {

        static void Main(string[] args)
        {
          double[] container;
          container = new double[4];
          Console.WriteLine("Enter numbers");

          for(int i=0; i<container.Length; i++)
          {
            container[i]=double.Parse(Console.ReadLine());
          }
          Converter somen = new Converter();

          Console.WriteLine("\nOutput:");
          Console.WriteLine($"{somen.Average_function(container)}");
          
         
        }
    }
}