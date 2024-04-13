using System;

namespace ConstantsC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constants are immutable values which are known 
            // at compile time and do not change for the life of the program.

            // constants as fields
            const double PI = 3.14159265359;
            const int weeks = 52, months = 12;
            // Create a constant of type string with your birthday as its value
            const string birthday = "07.03.1993";
            const string birthday2 = "05.31.1988";
            const string birthday3 = "2018-05-31";

            static void Main(string[] args)
            {
                Console.WriteLine("My birthday is always going to be: {0}", birthday);
                Console.ReadKey();
            }
        }
    }
}