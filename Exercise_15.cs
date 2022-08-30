/* Program to for guessing the magic word */


using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{

    
    internal class Program
    {

        static void Main(string[] args)
        {

          Console.WriteLine("**Guess the magic word**");
          string str1 = "somen";

          Console.WriteLine("Enter your world");
          string str2 = Console.ReadLine();

          bool b1 = String.Equals(str1,str2);

          if(b1==true) 
          {
            Console.WriteLine("\nBingo!!! you found the magic word");
          }
          else
          {
            Console.WriteLine($"\nWrong Guess!!!\nHint: Length of magic word is: {str1.Length}");
          }

          
          
         
        }
    }
} 