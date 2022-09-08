/* Program to reverse an array */


using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{

    class ArrayProblem
    {
      public static void arrayReverse(int[] arr, int start, int end)
      {
        int temp;
         
        while (start < end)
        {
            temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }

        arrayPrint(arr);

      }


      public static void arrayPrint(int[] arr)
      {
        for(int i=0;i<arr.Length;i++)
        {
          Console.Write($"{arr[i]}, ");
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

          int m= arr.Length;


          ArrayProblem.arrayReverse(arr,0,m-1);


          

          
          

          
          
          
         
        }
    }
} 