/* Program to convert Celsius into Fahrenheit and display them in tabular format */


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

    class Converter
    {
        public double Celsius_To_Fahrenheit(double cel)
        {
            return (cel*1.8)+32;
        }
    }

    
    internal class Program
    {

        static void Main(string[] args)
        {
           double[] arr = new double[5];
           Converter somen = new Converter();
           Console.WriteLine("Enter 5 Celsius values");

           for(int i=0; i<5; i++)
           {
             arr[i] = double.Parse(Console.ReadLine());

           }

           Console.WriteLine("\nOutput:");


           for(int j= 0; j<5; j++)
           {
             Console.WriteLine($"{arr[j]} Celsius = {somen.Celsius_To_Fahrenheit(arr[j])} Fahrenheit");
           }
           

          


            
       
                
            
         
        }
    }
}