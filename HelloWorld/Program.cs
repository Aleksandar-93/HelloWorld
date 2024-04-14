using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string numAsString = Console.ReadLine();
            int parsedVal;
            bool success = int.TryParse(numAsString, out parsedVal);

            if(success )
            {
                Console.WriteLine("Parsing Succsedsful - number is : " + parsedVal);
            }
            else
            {
                Console.WriteLine("parsing failed");
            }

        }

       


    }
}