using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Enhanced_If_Statements
{
    class Program {

        
        static void Main(string[] args)
        {
            int inputTemperature = 0;
            string temperatureMessaage = string.Empty; 
            string inputValue = string.Empty;

            // take input form console
            Console.WriteLine("enter the current tempeture : ");
            inputValue = Console.ReadLine();

            //validete the input as valid input integer value 
            bool validInteger = int.TryParse(inputValue, out inputTemperature); 

            if (validInteger)
            {
                //check for the condition
                temperatureMessaage = inputTemperature <= 15 ? "it is to cold here" : (inputTemperature >= 16 && inputTemperature <= 28) ? "it is cold here" : inputTemperature > 28 ? "it is hot here" : " ";
                Console.WriteLine(temperatureMessaage);
            }
            else
            {
                Console.WriteLine("Not a valid temperature");
            }

        }


    }
}