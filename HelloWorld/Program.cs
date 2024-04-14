using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;

           
          
            try
            {
               result = num1 / num2;

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("cant devide by Zeroo!");
            }




            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format expection, please neter corect type next time.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception, the number ws to long or to shgort for int32.");
            }
            finally
            {
                Console.WriteLine("Thiss is called anyweys!");
            } 



            Console.ReadKey();
        }

       


    }
}