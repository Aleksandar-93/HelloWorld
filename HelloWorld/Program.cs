using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //INT DOUBLE Float
           
        //declearing multiple variables at once
        int num3, num4, num5;
            int num1;
            //assigning value to variable
            num1 = 13;

            int num2 = 23;

            num2 = 100;
            //concanation
            Console.WriteLine("num1 is " + num1);
            int sum = num1 + num2;
            Console.WriteLine("num1 " + num1 + " num2 " + num2 + " is " + sum);

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is " + dDiv);

            float f1 = 3.1415f;
            float f2 = 5.1415f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 is " + fDiv);

            double dIDiv = d1 / num1;
            Console.WriteLine("di/num1 is " + dIDiv);
            // int dIDivInt = d1 / num1;
            //Console.WriteLine("di/num1 is " + dIDivInt);

            Console.Read();
        }
    }
}