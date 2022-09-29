using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_03
{
    public class order
    {

        public double Food_amount;
        public double Grocery_amount;
        public double Clothing_amount;

    }
    public class Food_Orders : order
    {
        double GST_per1 = 5;

        public void GST1()
        {
            double GST_Amount1 = Food_amount * GST_per1 / 100;
            Console.WriteLine($"GST AMOUNT  of Food: {GST_Amount1}");
        }


    }
    public class Grocery_Orders : order
    {
        double GST_per2 = 8;

        public void GST2()
        {
            double GST_Amount2 = Grocery_amount * GST_per2 / 100;
            Console.WriteLine($"GST AMOUNT  of Grocery: {GST_Amount2}");
        }
    }
    public class Clothing_Orders : order
    {
        double GST_per3 = 10;

        public void GST3()
        {

            double GST_Amount3 = Clothing_amount * GST_per3 / 100;
            Console.WriteLine($"GST AMOUNT  of Clothing: {GST_Amount3}");

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Food_Orders obj1 = new Food_Orders();

            obj1.Food_amount = 1000;
            obj1.GST1();

            Grocery_Orders obj2 = new Grocery_Orders();

            obj2.Grocery_amount = 2000;
            obj2.GST2();

            Clothing_Orders obj3 = new Clothing_Orders();

            obj3.Clothing_amount = 5000;
            obj3.GST3();
        }
    }
}