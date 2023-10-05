using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Integers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first No:"  );
            int num1=Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("Enyter the second No:");
            int num2 = Convert.ToInt32(Console.ReadLine());
          
            int sum = num1 + num2;

            if (num1 == num2)
            {
                int tripleSum = 3 * sum;
                Console.WriteLine($"The sum of the two integers is {sum}, and their triple is {tripleSum}");

            }
            else
            {
                Console.WriteLine($"The sum of the two integers is {sum}");

                Console.Read();
            }

        }
    }
}
