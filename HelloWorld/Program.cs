using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parsing a string to intager

            string myString = "15";
            string MySecondString = "13";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(MySecondString);
            int resultInt = num1 + num2;
            string result = myString + MySecondString; 

            Console.WriteLine(resultInt);
            Console.Read();

        }
    }
}