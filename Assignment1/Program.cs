using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void swapNos(int i,int j)
        {
            int temp = i;
            i=j;
            j=temp;
            Console.WriteLine($"First Number value is : {i}");
            Console.WriteLine($"Second Number value is : {j}");

        }
        static void Main(string[] args)
        {

            int i = 5;
            int j = 6; 
           
            Console.WriteLine($"First Number value is : {i}");
            Console.WriteLine($"Second Number value is : {j}");
            swapNos(i, j);
            Console.Read();

        }
    }
}
