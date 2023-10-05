using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Values
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double difference = Math.Abs(num1 - num2);

            if (num1 > num2)
            {
                double doubleDifference = 2 * difference;
                Console.WriteLine($"Double the absolute difference: {doubleDifference:F2}");
            }
            else
            {
                Console.WriteLine($"Absolute difference: {difference:F2}");
            }

            Console.Read();
        }
    }
}
