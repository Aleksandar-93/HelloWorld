using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace LoopChallenge
{
    class Program {

        
        static void Main(string[] args)
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while (input != "-1")
            {
                Console.WriteLine("Last number was {0}", currentNumber );
                Console.WriteLine("Please enter the next score");
                Console.WriteLine("Currnt amount of entires {0}", count);
                Console.WriteLine("Please entere -1 once you are redy yo calculate the averge");

                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    Console.WriteLine("-------------------------------------");
                    double avrage = (double)total / (double)count;
                    Console.WriteLine("the avrage score of your student is {0}", avrage);
                }
                if(int.TryParse(input, out currentNumber) && currentNumber >0 && currentNumber < 21 )
                {
                    total += currentNumber;
                }
                else
                {
                    if(!(input.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a value betwen 1 and 20!");
                    }
                    continue;
                }

                count++;

            }


            Console.Read();
        }
  
        
    }
}