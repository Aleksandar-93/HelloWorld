using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace UsserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate();
            Console.Read();
        }

        public static void Calculate() 
        {

            Console.WriteLine("Plis insert first nummber");
            string input1 = Console.ReadLine();
            Console.WriteLine("Plis insert second nummber");
            string input2 = Console.ReadLine();

            double addTwoString = double.Parse(input1) + double.Parse(input2);
            double subTwoString = double.Parse(input1) - double.Parse(input2);
            double mulTwoString = double.Parse(input1) * double.Parse(input2);
            double divTwoString = double.Parse(input1) / double.Parse(input2);

            Console.WriteLine("First number + second number is " + addTwoString);
            Console.WriteLine("First number - second number is " + subTwoString);
            Console.WriteLine("First number * second number is " + mulTwoString);
            Console.WriteLine("First number / second number is " + divTwoString);


            
        }


    }
}