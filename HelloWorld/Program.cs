using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace DoWhile
{
    class Program {

        
        static void Main(string[] args)
        {
            int lenghtOfText = 0;
            string wholeText = " ";
            do
            {
                Console.WriteLine("Please enter the name of friend");
                string nameOfAFriend = Console.ReadLine();
                int currentLenght = nameOfAFriend.Length;
                lenghtOfText += currentLenght;
                wholeText += nameOfAFriend;
            } while (lenghtOfText < 20);
                Console.WriteLine("Thenks, that was enough! " + wholeText);




            Console.Read();
        }
  
        
    }
}