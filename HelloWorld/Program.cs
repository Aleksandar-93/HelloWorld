using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace BrakeContinu
{
    class Program {

        
        static void Main(string[] args)
        {
            for(int i = 0; i < 10;  i++)
            {
                if(i %2 == 0)
                {
                    Console.WriteLine("Now comes an odd number");
                    continue;
                }
                Console.WriteLine(i);

            }


            Console.Read();
        }
  
        
    }
}