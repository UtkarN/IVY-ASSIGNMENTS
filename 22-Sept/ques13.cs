using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = " Utkarsh Nigam";

            int len = str1.Length;

            string str2 = " ";
            int i = 0;
            while (i < len)
            {
                if (Char.IsLower(str1[i]))
                {
                    str2 = str2 + Char.ToUpper(str1[i]);
                }
                else if (Char.IsUpper(str1[i]))
                {
                    str2 = str2 + Char.ToLower(str1[i]);
                }
                else
                {
                    str2 = str2 + " ";
                }
                i++;
            }
            Console.WriteLine(str2);
        }
    }
}
-----------------------------------------------------------------
Question_14
------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_14
{
    internal class Program
    {
        public static int length_Of_Longest_Substring(String s)
        {
            int length = 0;
            for (int start = 0; start < s.Length; start++)
            {
                int i = start;
                var dictionary = new Dictionary<char, int>();

                while (i < s.Length && !dictionary.ContainsKey(s[i]))
                {
                    dictionary.Add(s[i++], 1);
                }
                if (i - start > length)
                {
                    length = i - start;
                }
            }

            return length;
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int len = length_Of_Longest_Substring(str);

            Console.WriteLine(len);
        }


    }
}