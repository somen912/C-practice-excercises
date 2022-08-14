/* Write a program that takes the line of text 
   John F Kennedy
   as a command line input and display the following output
   Kennedy John F */


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {  
           

            Console.WriteLine("Enter Name");
            string line1=Console.ReadLine();
            
            string[] word=line1.Split();

            string final= word[2]+" "+word[0]+" "+word[1];
            Console.WriteLine($"\nOutput:");
            Console.WriteLine($"{final}");

           

         
        }
    }
}