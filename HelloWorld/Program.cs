using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Manipulation

            int age = 28;
            string name = "Alfonso";
            string job = "Devoloper";

            // 1. String concatenation 
            Console.WriteLine("String concatienation");
            Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old");

            // 2. String formating 
            // String format use index
            Console.WriteLine("String formating");
            Console.WriteLine("Hello my name is {0} , I am {1} years old. I'm a {2}",name,age,job);

            // 3. String interpolation 
            // String interpolation use $ at the start wich will allow us to write wariables like this {name}
            Console.WriteLine("String interpolation");
            Console.WriteLine($"Hello my name is {name} , I am {age} years old.", name, age);

            // 4. verbatim Strings
            // verbatim Strings start with @ and tell compiler to take a string
            //literally and ignore any spaces and escape chiracter like \n
            Console.WriteLine("verbatim Strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do 

            eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore 
            eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in


            culpa qui officia deserunt mollit anim id est 
            laborum.");
            //good for 
            Console.WriteLine(@"c:\User\Admin\Pictures\.....");


            // \n next line (line brake ) but @ ignore line brake 
            Console.WriteLine(@"Muhaha \n you dont have power here!.");
            Console.WriteLine("Muhaha \n you dont have power here!.");

        }
    }
}