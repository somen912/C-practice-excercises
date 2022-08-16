/* Program for explaining the concept of boxing and unboxing */


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

    internal class Program
    {

        static void Main(string[] args)
        {
            int a = 10;
            string b = "somen";
            double d = 100.125;

            Console.WriteLine($"\nType of a : {a.GetType()}\n Type of b : {b.GetType()}\n Type of c: {d.GetType()}");

            // Boxing 

            object e = a;
            object f = b;
            object g = d;

            Console.WriteLine($"\nType of e : {e.GetType()}\n Type of f : {f.GetType()}\n Type of g: {g.GetType()}");

            // Unboxing 

            int h = (int) e;
            string i =(string) b;
            double j = (double)d;

            Console.WriteLine($"\nType of h : {h.GetType()}\n Type of i : {i.GetType()}\n Type of j: {j.GetType()}");
           
        
                    

                    
                   
                
            
         
        }
    }
}