using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dis, time;

            dis = Convert.ToDouble(Console.ReadLine());// in km
            time = Convert.ToDouble(Console.ReadLine()); // in hours

            double speed = dis / time;

            Console.WriteLine($"speed in km per hour {speed}");
            // 1 mile = 1.609 km
            // 1 km = 1/1.609 mile

            // speed km = speed/1.609 miles;
            Console.WriteLine($"speed in miles per hour {speed / 1.609}");

        }
    }
}
-------
