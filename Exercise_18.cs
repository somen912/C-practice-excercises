/* Maximum and minimum of an array using Linear Search */


using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{

    class ArrayProblem
    {
      public int min,max;

      public void findMinMax(int[] arr, int n)
      {
        if(n==1)
        {
          min = arr[0];
          max = arr[0];
        }

        if(arr[0]>arr[1])
        {
          min = arr[1];
          max = arr[0];
        }
        else
        {
          min = arr[0];
          max = arr[1];
        }

        for(int i=2;i<n;i++)
        {
          if(arr[i]<min)
          {
            min = arr[i];
          }
          else if(arr[i]>max)
          {
            max = arr[i];
          }
        }
        
      }
    }

  
    internal class Program
    {

        static void Main(string[] args)
        {

          Console.WriteLine("Enter number of element you want to enter");
          int n = int.Parse(Console.ReadLine());

          int[] arr;
          arr = new int[n];

          Console.WriteLine("Enter array elements");

          for(int i=0;i<n;i++)
          {
            arr[i]= int.Parse(Console.ReadLine());
          } 


          ArrayProblem somen = new ArrayProblem();

          somen.findMinMax(arr,n);

          Console.WriteLine($"min: {somen.min} \nmax: {somen.max}");

          
          

          
          
          
         
        }
    }
} 
