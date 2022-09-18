/* A simple program to find Factors, Factorial, LCM & HCF */


using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{

    static class Operation
    {
      

      public static int getFactorial(int num)  // method to find factorial
      {
        int factorial =1;
      
        for(int i =1; i<=num; i++)
        {
          factorial *= i; 
        }

        return factorial;
      }

      public static void getFactors(int num)   // method to find factors
    {
      for(int i=1;i<=num;i++)
      {
        if(num%i==0)
        {
          Console.Write($"{i}, ");
        }

      }
    }

    public static void getLCM(int a, int b)   // method to find LCM
    {
      int i = a<b?b:a;
      for(i =1 ;i<=(a*b);i++)
      {
        if(i%a==0 && i%b==0)
        {
          break;
        }
      }
      System.Console.WriteLine($"\nLCM : {i}");
    }


    public static void getHCF(int a, int b)          // Method to find HCF
    {
      int i;
      

      for(i=a<b?a:b; i>=1; i--)
      {
        if(a%i==0 && b%i==0)
        {
          break;
        }

        
      }

      System.Console.WriteLine($"HCF: {i}");
    }

    }      
    

    

  
    internal class Program
    {

        static void Main(string[] args)
        {
          
          Console.WriteLine($"Factorial: {Operation.getFactorial(5)}");

          Operation.getFactors(27);

          Operation.getLCM(2,3);

          Operation.getHCF(4,6);
          
         
        }
    }
} 