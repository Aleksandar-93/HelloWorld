using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int temp = int.Parse(temperature);

            if(temp < 20)
            {
                Console.WriteLine("take the coat");

            }else if(temp == 20)
            {
                Console.WriteLine("Pants and pull over shold be fine");
            }
            else
            {
                Console.WriteLine(" Shorts are enough tiday ");

            }

           
        }

       


    }
}