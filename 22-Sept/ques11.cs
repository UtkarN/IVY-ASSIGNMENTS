using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 10, 8, 5, 4, 2, 10 };

            int cnt1 = 0, cnt2 = 0;

            foreach (int ele in arr1)
            {
                if (ele % 2 == 0) cnt1++;
                else cnt2++;
            }


            int len1 = arr1.Length;
            int[] arr2 = new int[cnt1];
            int[] arr3 = new int[cnt2];

            int i = 0, j = 0, k = 0;

            while (i < len1)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j++] = arr1[i++];

                }
                else
                {
                    arr3[k++] = arr1[i++];
                }

            }

            foreach (int item in arr2)
                Console.Write(item + " ");
            Console.ReadLine();

            foreach (int item in arr3)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
