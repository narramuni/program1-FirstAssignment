using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Numbers
    {

        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter third number: ");
            double z = Convert.ToDouble(Console.ReadLine());

            double result1 = (x + y) * z;
            double result2 = (x * y) + (y * z);

            Console.WriteLine($"Result of specified numbers {x}, {y}, and {z}, (x+y).z is {result1} and x.y + y.z is {result2}");

            Console.Read();
        
    }
    }
}
