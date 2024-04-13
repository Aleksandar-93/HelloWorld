using System;
using System.Security.Cryptography.X509Certificates;

namespace functionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomting();
            WriteSomtingSpecific("I am a argument and i am called from a method");
            Console.ReadLine();
            
        }

        public static void WriteSomting()
        {
            Console.WriteLine("I am called from a method");
        }
        public static void WriteSomtingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
    }
}