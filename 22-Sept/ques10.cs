using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3 };

            int[] arr2 = new int[] { 4, 9, 3 };

            int[] combined = arr1.Concat(arr2).ToArray();

            Array.Sort(combined);

            foreach (int i in combined)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
