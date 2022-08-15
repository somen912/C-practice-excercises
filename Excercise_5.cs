/* Write a program that would illustrate the concept of declaration and inatialization of value type variables. 
   Use the following literals for initializing the variables. 
   1. 'A'
   2. '50'
   3. 123456789
   4. 1234567654321
   5. true
   6. 0.000000345
   7. 1.23e.5 */


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

   

    internal class Program
    {

        static void Main(string[] args)
        {
           char a = 'A';
           int b = 50;
           int c = 123456789;
           decimal d = 1234567654321;
           bool e = true;
           double f = 0.000000345;
           string g = "1.23e.5";

           Console.WriteLine("\nOutput:");
           Console.WriteLine($"data type of {a} is {a.GetType()}\ndata type of {b} is {b.GetType()}\ndata type of {c} is {c.GetType()}\ndata type of {d} is {d.GetType()}\ndata type of {e} is {e.GetType()}\ndata type of {f} is {f.GetType()}\ndata type of {g} is {g.GetType()}");

        
                    

                    
                   
                
            
         
        }
    }
}