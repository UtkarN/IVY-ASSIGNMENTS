using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "This is a ASSignment";

            char[] str2 = str.ToCharArray();

            int len = str.Length;

            for (int c = len - 1; c >= 0; c--)
                Console.Write(str2[c]);
            Console.WriteLine();
        }
    }
}
