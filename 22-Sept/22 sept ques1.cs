using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch1, ch2, ch3;

            ch1 = Convert.ToChar(Console.ReadLine());
            ch2 = Convert.ToChar(Console.ReadLine());
            ch3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(ch3 + " " + ch2 + " " + ch3);

        }
    }
}
