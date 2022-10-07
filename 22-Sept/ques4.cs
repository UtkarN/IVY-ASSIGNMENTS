using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_04
{
    internal class Program
    {
        static bool IsEqual(int x, int y)
        {
            if (x % 2 == 0 && y % 2 == 0) return true;
            return false;
        }
        static void Main(string[] args)
        {
            int num1, num2;

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsEqual(num1, num2));

        }
    }
}