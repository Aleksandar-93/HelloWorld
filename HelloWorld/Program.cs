using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parsing a string to intager


            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float stringToFloat = float.Parse(stringForFloat);
            int stringToInt = int.Parse(stringForInt);


            Console.WriteLine(stringForInt);
            Console.Read();

        }
    }
}