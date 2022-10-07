using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ques_08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int side1, side2, side3;

            side1 = Convert.ToInt32(Console.ReadLine());
            side2 = Convert.ToInt32(Console.ReadLine());
            side3 = Convert.ToInt32(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
                Console.WriteLine("The Given Triangle is equilateral\n");
            else if (side1 == side2 || side2 == side3 || side3 == side1)
                Console.WriteLine("The given Triangle is isosceles\n");
            else
                Console.WriteLine("The given Triangle is scalene\n");
        }
    }
}
