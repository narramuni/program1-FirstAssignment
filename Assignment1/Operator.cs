using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Operator
    {
        static void Main()
        {
            Console.Write("Input the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            double quotient = (double)num1 / num2;
            int remainder = num1 % num2;

            Console.WriteLine($"{num1} + {num2} = {sum}");
            Console.WriteLine($"{num1} - {num2} = {difference}");
            Console.WriteLine($"{num1} x {num2} = {product}");
            Console.WriteLine($"{num1} / {num2} = {quotient}");
            Console.WriteLine($"{num1} mod {num2} = {remainder}");

            Console.Read();
        }
    }
}
