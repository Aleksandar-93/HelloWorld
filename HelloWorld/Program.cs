using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace OperatorsC
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators
            num3 = -num1; // multiply num1 wihh -1
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}",!isSunny);

            // icremaemant operators

            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);  //1
            Console.WriteLine("num is {0}", num++);  //1
            /// pre increment
            Console.WriteLine("num is {0}", ++num); //3

            // decrement operators
            num--;
            Console.WriteLine("num is {0}", num);  //2
            Console.WriteLine("num is {0}", num--);  //2
            /// pre increment
            Console.WriteLine("num is {0}", --num); //0


            int result;
            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is {0}", result);
            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is {0}", result);

            // relational and type operaors 
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("result of num1 < num2 is {0}", isLower);

            // equality operaotrs
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("result of num1 == num2 is {0}",isEqual);
            isEqual = num1 != num2;
            Console.WriteLine("result of num1 != num2 is {0}", isEqual);

            // conditional operators

            bool isLowerAndSunny;
            // Condition1 AND condition 2
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLowerAndSunny is {0}", isLowerAndSunny);
            // Condition1 OR condition 2
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("result of isLowerAndSunny is {0}", isLowerAndSunny);

            Console.ReadKey();
        }

       


    }
}