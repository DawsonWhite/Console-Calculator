using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            float result;
            String operation;

            Console.WriteLine("Hello, welcome to the 2-input calculator program!");
            
            Console.WriteLine("Please enter your first number");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number");
            num2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Please type 'a' for addition, 's' for subtraction, 'm' for multiply, or 'd' for divide");
            operation = Console.ReadLine().ToLower();
            
                switch (operation)
                {
                    case "a":
                        result = num1 + num2;
                        Console.WriteLine("Result is " + result);
                        break;
                    case "s":
                        result = num1 - num2;
                        Console.WriteLine("Result is " + result);
                        break;
                    case "m":
                        result = num1 * num2;
                        Console.WriteLine("Result is " + result);
                        break;
                    case "d":
                        result = num2 == 0? float.NaN : num1 / num2;

                    if (float.IsNaN(result))
                    {
                        Console.WriteLine("Cannot divide by 0");
                    }
                    else
                    {
                        Console.WriteLine("Result is " + result);
                    }
                        break;
                    default:
                        break;
                }
            


            Console.ReadKey();
        }
    }
}
