/* A simple example of struct and enum */


using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{

  struct converter           //    defining struct
  {
    public enum shape{circle, square};  //enumeration


    public void showArea(int a, shape b)
    {
      switch (b)
      {
        case shape.circle:
                  Console.WriteLine($"Area of {shape.circle}: {Math.PI*(a*a)}");
                  break;
        case shape.square:
                  Console.WriteLine($"Area of {shape.square}: {a*a}");
                  break;          
        default:
                  break;          
                
      }
    }
  }

    
    internal class Program
    {

        static void Main(string[] args)
        {

          converter somen;

          somen.showArea(12,converter.shape.circle);
          somen.showArea(12,converter.shape.square);

          

          
          
          
         
        }
    }
} 