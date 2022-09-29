using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int phy, chem, math;

            phy = Convert.ToInt32(Console.ReadLine());
            chem = Convert.ToInt32(Console.ReadLine());
            math = Convert.ToInt32(Console.ReadLine());

            if (math >= 65)
                if (phy >= 55)
                    if (chem >= 50)
                        if ((math + phy + chem) >= 180 || (math + phy) >= 140)
                            Console.WriteLine("The  candidate is eligible for admission");
                        else
                            Console.WriteLine("The candidate is not eligible");
                    else
                        Console.WriteLine("The candidate is not eligible");
                else
                    Console.WriteLine("The candidate is not eligible");
            else
                Console.WriteLine("The candidate is not eligible");
        }
    }
}
