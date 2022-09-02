/* Simple String exercise */


using System;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;

namespace MyApp // Note: actual namespace depends on the project name.
{

    
    internal class Program
    {

        static void Main(string[] args)
        {

          Console.WriteLine("Enter Your name");
          string str1 = Console.ReadLine();

          if(str1.Length>2)
          {
            

            if(char.IsNumber(str1,0)||char.IsNumber(str1,1))
            {
              Console.WriteLine("Name should not contains number ");
            }
            else if(char.IsLower(str1,0))
            {
              Console.WriteLine("First Letter should be capital");

            }
            else if(char.IsUpper(str1,1)||char.IsUpper(str1,2))
            {
              Console.WriteLine("Only 1st letter should be capital");
            }
            else if(str1.Contains("S"))
            {
              Console.WriteLine($"Wow Your name {str1} starts with S");
              Regex name = new Regex("|,");
              foreach(string a in name.Split(str1))
              {
                Console.Write($"{a}");
                if(a==" "||a==",")
                {
                  Console.WriteLine($"{a}");

                }
              }
              
            }
            else
            {
              Console.WriteLine($"Name:{str1}");
            }




          }
          else{
            Console.WriteLine("Enter a valid name");
          }

          
          
         
        }
    }
} 