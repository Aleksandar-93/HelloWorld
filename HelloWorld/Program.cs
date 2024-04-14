using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;

            if(int.TryParse(temperature, out number))
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered, was no number, 0 set as temperature");
            }


            if (numTemp < 20)
            {
                Console.WriteLine("Take the coat");
            }

            if (numTemp == 20)
            {
                Console.WriteLine("Pants and Pull Over should be fine");
            }

            if (numTemp > 20)
            {
                Console.WriteLine("Shorts are enough today");
            }

            Console.Read();
        }

       


    }
}