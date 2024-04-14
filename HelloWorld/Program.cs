using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Nikola";
            string friend2 = "Pera";
            string friend3 = "Vlada";

            GreatFriend(friend1);
            GreatFriend(friend2);
            GreatFriend(friend3);

            Console.Read();
        }

        
        public static void GreatFriend(string friendName)
        {
            Console.WriteLine("Hi " +  friendName + " , my friend!");
        }


    }
}