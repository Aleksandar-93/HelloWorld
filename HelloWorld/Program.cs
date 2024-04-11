using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inplicit and explicit Conversion


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