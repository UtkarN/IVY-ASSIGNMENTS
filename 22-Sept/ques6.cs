using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] height = new int[10];

            for (int i = 0; i < height.Length; i++)
                height[i] = Convert.ToInt32(Console.ReadLine());

            foreach (int i in height)
            {
                if (i < 135) Console.WriteLine("Short");
                if (i > 180) Console.WriteLine("Tall");
                if (i > 135 && i < 180) Console.WriteLine("Average");
            }
        }
    }
}
