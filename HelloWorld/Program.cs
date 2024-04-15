using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ifPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your user name");
            userName = Console.ReadLine();

            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there, registred user");
                Console.WriteLine("Hi there " + userName);
                Console.WriteLine("Hi there, Admin");
                
            }

            if(isAdmin || isRegistered)
            {
                Console.WriteLine("You are loged in");
            }

            Console.Read();
            
        }

       


    }
}