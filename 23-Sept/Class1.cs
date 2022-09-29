using System;


namespace LambdaExpression
{


    public delegate int greater(int a,int b);
    // multicast 

    internal class Program
    {

        static void Main(string[] args)
        {


            greater obj = (p,q) => large=(p>q)?p:q;


            Console.WriteLine("Enter a number1");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number2");
            int b= int.Parse(Console.ReadLine());

            Console.WriteLine(obj.Invoke(a,b)); ;



        }
    }
}