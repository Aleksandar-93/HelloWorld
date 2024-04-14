using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Parametars
{
    class Program
    {
        //Return Value And Parametars
        static void Main(string[] args)
        {
            //Add(Add(1,2),Add(3,4)); 
            Console.WriteLine(Devide(25,13));
            Console.Read();
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2; 
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Devide(double num1, double num2)
        {
            return num1 / num2;
        }

    }
}