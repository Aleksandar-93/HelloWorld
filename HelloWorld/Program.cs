﻿using System;

namespace StringPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            //data types pratice

            byte myByte = 25; // 0 to 255
            Console.WriteLine(myByte);
            sbyte mySbyte = -15;// -128 to 127
            Console.WriteLine(mySbyte);
            int myInt = -12318925; // -2,147,483,648 to 2,147,483,647
            Console.WriteLine(myInt);
            uint myUint = 123091; // 0 to 4294967295
            Console.WriteLine(myUint);
            short myShort = -32768; // -32,768 to 32,767
            Console.WriteLine(myShort);
            ushort myUShort = 65535; // 0 to 65535
            Console.WriteLine(myUShort);
            float myFloat = -31.1289f; // -3.402823e38 to 3.402823e38
            Console.WriteLine(myFloat);
            double myDouble = -12.1231250; //-1.79769313486232e308 to 1.79769313486232e308
            Console.WriteLine(myDouble);
            char myCharacter = 'A'; //Unicode symbols used in text
            Console.WriteLine(myCharacter);
            bool myBool = true; // True or false
            Console.WriteLine(myBool);
            string myText = "I control text";  //A sequence of characters
            Console.WriteLine(myText);
            string numText = "15";

            int myNumFromText = int.Parse(numText);
            Console.WriteLine(myNumFromText);
            Console.ReadLine();

        }
    }
}