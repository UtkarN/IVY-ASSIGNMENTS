using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0)
            {
                Console.WriteLine($"{year} is leap year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine($"{year} is not a leap year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine($"{year} is leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }
        }
    }
}
