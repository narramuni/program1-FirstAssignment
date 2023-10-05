using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Display_5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a digit: ");
            int number = Convert.ToInt32(Console.ReadLine());

          
            Console.Write($"{number} {number} {number} {number}\n");
            Console.Write($"{number}{number}{number}{number}\n");   

       
            Console.WriteLine("{0} {0} {0} {0}", number);            
            Console.WriteLine("{0}{0}{0}{0}", number);

            Console.Read();

        }
    }
}
