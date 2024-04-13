using System;

namespace StringPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            //String pratice

            Console.Write("Enter the string here: ");
            //Read first input string.
            string input = Console.ReadLine();

            Console.Write("Enter the Character to search: ");
            //return first character of input
            char searchInput = Console.ReadLine()[0];
            //Get the index of the character from string
            int searchIndex = input.IndexOf(searchInput);
            Console.WriteLine("Index of Character {0} in string is {1}", searchIndex,searchInput);

            Console.Write("Enter first name: ");
            //Read first name
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            //Read last name 
            string lastName = Console.ReadLine();

            //Concatinate first name and last
            string fullName = string.Concat(firstName," ",lastName);
            // print full name
            Console.WriteLine("Your full name is {0} ",fullName);

            Console.ReadKey();
        }
    }
}