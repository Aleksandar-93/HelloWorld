using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace SwitchCase
{
    class Program { 


        static void Main(string[] args)
        {
            int age = 25;

            switch (age)
            {
                case 15:
                    Console.WriteLine("To yoing to party in the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                 default:
                    Console.WriteLine("how old are you then?");
                 break;
            }

            if (age == 15)
            {
                Console.WriteLine("To yoing to party in the club!");
            }else if (age == 25)
            {
                Console.WriteLine("Good to go!");
            }
            else
            {
                Console.WriteLine("how old are you then?");
            }

            // strings

            string userName = "Denis";

            switch(userName) 
            {
                case "Dneis":
                    Console.WriteLine("username is Denis");
                    break;
                case "Root":
                    Console.WriteLine("username is Root");
                    break;
                default:
                    Console.WriteLine("Username is unknown");
                    break;
            }


        }

      


    }
}