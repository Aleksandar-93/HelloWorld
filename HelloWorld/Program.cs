using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace RegisteringAndLogginIn
{
    class Program { 

        static string username;
        static string password;

        static void Main(string[] args)
        {
            Register();
            login();
            Console.Read();
        }

       public static void Register()
        {
            Console.WriteLine("please enter your username");
            username = Console.ReadLine();
            Console.WriteLine("please enter your password");
            password = Console.ReadLine();
            Console.WriteLine("Registration complited");
            Console.WriteLine("-------------------------------------------");

        }

        public static void login()
        {
            Console.WriteLine("please enter your username");
            if(username == Console.ReadLine())
            {
                Console.WriteLine("please enter your password");
                if(password == Console.ReadLine())
                {
                    Console.WriteLine("Login Succseflul");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password. Restart Program");
                }
            }
            else
            {
                Console.WriteLine("Login failed, wrong password. Restart Program");
            }
        }


    }
}