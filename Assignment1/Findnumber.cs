using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Findnumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First No:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second No:");
            int num2 = int.Parse(Console.ReadLine());   

            int max = (num1>num2) ? num1 : num2;
            
            int min = (num1<num2) ? num1 : num2;

            Console.WriteLine($"Max number is:{max}"  );
            Console.WriteLine($"Min number is :{min}"  );

            Console.Read();

        }
    }
}
