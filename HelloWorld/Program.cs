using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit and explicit Conversion

            // Implicit Conversion
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;


            //explicit Conversion
            double myDouble = 13.37;
            int myInt;
            //cast double to int 
            myInt = (int)myDouble; 

            //typeConversion 
            string myString = myDouble.ToString(); //"13.37"

            Console.WriteLine(myInt);
            Console.Read();
        }
    }
}