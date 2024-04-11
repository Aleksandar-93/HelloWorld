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

            float myFloat = 13.37;
            dobule myNewDouble = myFloat;


            //explicit Conversion
            double myDouble = 13.37;
            int myInt;
            //cast double to int 
            myInt = (int)myDouble; 
            Console.WriteLine(myInt);
            Console.Read();
        }
    }
}