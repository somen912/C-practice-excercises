/* Define two classes, one with a method to display the string "C sharp"
   and the other to display the string "programming".
   Write a program using these classes to display a single line output as follows
   "C sharp programming" */


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class student1
    {
        public string print (string a)
        {
           // Console.WriteLine($"{a}");
           return a;
        }

    }

    public class student2
    {
        public string print (string a)
        {
            //Console.WriteLine($"{a}");
            return a;
        }

    }


    internal class Program
    {

        static void Main(string[] args)
        {  

            student1 somen = new student1();
            student2 surbhi = new student2();

            Console.WriteLine("\nOutput:");
            Console.WriteLine($"{somen.print("C sharp")} {surbhi.print("programming")}");
           

         
        }
    }
}