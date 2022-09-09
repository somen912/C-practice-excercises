/* Program to Largest Sum Contiguous Subarray (Kadane’s Algorithm) */


using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{

    class ArrayProblem
    {
      
      public static int findMaxsubarray (int[] arr)
      {
        int sum_element = int.MinValue, element = 0;

        for(int i=0;i<arr.Length;i++)
        {
          element += arr[i];
          if(sum_element < element)
          {
            sum_element=element;
          }
          if(element<0)
          {
            element =0;
          }
          

        }
        return sum_element;
      }


      
    }

  
    internal class Program
    {

        static void Main(string[] args)
        {

          int[] arr = {-2, -3, 4, -1, -2, 1, 5, -3};

          int output = ArrayProblem.findMaxsubarray(arr);

          Console.Write($"output: {output}");


          
          
          
         
        }
    }
} 