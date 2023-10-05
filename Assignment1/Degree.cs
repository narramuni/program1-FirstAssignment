using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Degree
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

     
            double kelvin = celsius + 273.15;

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"Kelvin = {kelvin:F0}");
            Console.WriteLine($"Fahrenheit = {fahrenheit:F0}");

            Console.Read();
        }
    }
}
