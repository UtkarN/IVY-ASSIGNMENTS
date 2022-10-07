using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_05
{
    abstract class Bank_Account
    {
        public abstract void Link_Aadhar_Bank_AccNo();

    }
    class Link : Bank_Account
    {
        double aadhar_no;
        public Link()
        {
            aadhar_no = Convert.ToDouble(Console.ReadLine());

        }
        public override void Link_Aadhar_Bank_AccNo()
        {
            Console.WriteLine("Link Bank Account Number with Aadhar Number Successfully!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Link link = new Link();

            link.Link_Aadhar_Bank_AccNo();
        }
    }
}
