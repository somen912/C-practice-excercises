/* Write a program to read two strings from keyboard using the Readline statements 
and display them on one line using two write statement*/



using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {  
            Console.WriteLine("Enter first sentence");
            string line1=Console.ReadLine();
            Console.WriteLine("Enter second sentence");
            string line2=Console.ReadLine();

            Console.WriteLine("\nOutput:");
            Console.WriteLine($"{line1} {line2}");

           

         
        }
    }
}