using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Enhanced_If_Statements
{
    class Program {

        
        static void Main(string[] args)
        {
            //[condition] ? [first expression] : [second expression]
            //condition has to be either true or false

            //The conditional Operator is right-associative
            //That means, that a ? b : c ? d : e
            // is evaluated as a ? b : (c ? d : e)

            //The conditional Operator cannot be overloaded.


            int temperature = -5;
            string stateOfMatter;

            if (temperature < 0)
                stateOfMatter = "solid";
            else
                stateOfMatter = "liquid";
                Console.WriteLine("State of mater is {0}",stateOfMatter);


            // in short

            stateOfMatter = temperature < 0 ? "solid" : "liquid";

            // gass state of matter 
            temperature += 100;
            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

            Console.WriteLine("State of mater is {0}", stateOfMatter);
            Console.ReadKey();

            temperature += 30;



        }


    }
}