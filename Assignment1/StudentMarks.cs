using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class StudentMarks
    {
        static void Main(string[] args)
        {
            Console.Write("Enter marks in the first subject: ");
            int subject1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in the second subject: ");
            int subject2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in the third subject: ");
            int subject3 = Convert.ToInt32(Console.ReadLine());

            int totalMarks = subject1 + subject2 + subject3;
            double percentage = (totalMarks / 3.0);

            Console.WriteLine($"Total Marks: {totalMarks}");
            Console.WriteLine($"Percentage: {percentage}%");

            if (percentage < 35)
            {
                Console.WriteLine("Result: Fail");
            }
            else if (percentage >= 35 && percentage < 45)
            {
                Console.WriteLine("Result: Third Division");
            }
            else if (percentage >= 45 && percentage < 60)
            {
                Console.WriteLine("Result: Second Division");
            }
            else
            {
                Console.WriteLine("Result: First Division");
            }

            Console.Read();
        }
    }
}
