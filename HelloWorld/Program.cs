using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //STRING
            string myname = "Denis";
            string message = "my name is " + myname;
            string capsMessage = message.ToUpper();
            string lowerMessage = message.ToLower();
            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerMessage);
            Console.Read();
        }
    }
}