using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Enhanced_If_Statements
{
    class Program {

        
        static void Main(string[] args)
        {
            for(int counter = 0; counter < 50;  counter+=5) // add 5 evry time 
            {
                Console.WriteLine(counter);
            }
            Console.WriteLine("for loop is done");

            // print odd numbers
            Console.WriteLine("odd numbers");
            for(int counter = 0; counter <20; counter+=2)
            {
                Console.WriteLine(counter);
            }



            Console.Read();
        }
  
        
    }
}