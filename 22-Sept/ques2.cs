using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, a;

            r = Convert.ToDouble(Console.ReadLine());

            double perimeter = 2 * 3.14 * r;

            a = 2 * 3.14 * r * r;

            Console.WriteLine($"Perimeter: {perimeter}");
            Console.WriteLine($"Area: {a}");
        }
    }
}