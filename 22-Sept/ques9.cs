using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Array;


namespace Ques_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3 };

            int[] arr2;

            arr2 = arr1;

            foreach (int i in arr2)
                Console.Write(i + " ");
            Console.WriteLine();


            // Array.CopyTo(arr2,0);

        }
    }
}

