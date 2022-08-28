/* Example of 3x3 Metrix multiplication */


using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{

    class Converter
    {
      
      
      
        
    }

    
    internal class Program
    {

        static void Main(string[] args)
        {
          int row = 3;
          int column = 3;
          int[,] arr1 = new int[row,column]; // declaration of 2D array
          int[,] arr2 = new int[row,column];
          int[,] arr3 = new int[row,column];

          Console.WriteLine("Enter Inputs for metrix 1");  // Taking input for 1st metrix

          for(int i=0;i<row;i++)
          {
            for(int j=0;j<column;j++)
            {
              arr1[i,j]=int.Parse(Console.ReadLine());
            }
          }

          Console.WriteLine("\nMetrix 1:"); // Printing values of 1st metrix

          for(int i=0;i<row;i++)
          {
            for(int j=0;j<column;j++)
            {
              Console.Write($"{arr1[i,j]} ");
            }
            Console.WriteLine();
          }


          Console.WriteLine("Enter Inputs for metrix 2"); // Taking input for 2nd metrix

          for(int i=0;i<row;i++)
          {
            for(int j=0;j<column;j++)
            {
              arr2[i,j]=int.Parse(Console.ReadLine());
            }
          }

          Console.WriteLine("\nMetrix 2:");   // Printing values for 2nd metrics

          for(int i=0;i<row;i++)
          {
            for(int j=0;j<column;j++)
            {
              Console.Write($"{arr2[i,j]} ");
            }
            Console.WriteLine();
          }



          for(int i=0;i<row;i++)   // Metrix multiplication operation
          {
            for(int j=0;j<column;j++)
            {
              int sum =0;
              for(int k=0;k<3;k++)
              {
                sum+= (arr1[i,k]*arr2[k,j]);

              }
              arr3[i,j]=sum;
            }
            
          }


          Console.WriteLine("\nMultiplied output is:");    // Printing metrix multiplication output

          for(int i=0;i<row;i++)
          {
            for(int j=0;j<column;j++)
            {
              Console.Write($"{arr3[i,j]} ");
            }
            Console.WriteLine();
          }
          
         
        }
    }
} 