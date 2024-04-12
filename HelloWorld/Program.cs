using System;

namespace StringPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            //String pratice

            string myName;
            Console.Write("Please enter your name and press enter : "); //same line 
            myName = Console.ReadLine(); // ask for input 
            string myNameUpperCase = String.Format("Upper case :{0}", myName.ToUpper());
            string myNameLowerCase = String.Format("Lower case :{0}", myName.ToLower()); 
            string myNameTrimed = String.Format("Trimed value case :{0}", myName.Trim()); // Remove empty spaces beffore and affter string
            string myNameSubstring = String.Format("Substring value :{0}", myName.Substring(0,5));   // start at 0 lenght of 5

            Console.WriteLine(myNameUpperCase);
            Console.WriteLine(myNameLowerCase);
            Console.WriteLine(myNameTrimed);
            Console.WriteLine(myNameSubstring);


        }
    }
}