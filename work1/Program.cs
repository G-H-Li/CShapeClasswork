using System;

namespace work1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;

            Console.WriteLine("C# console calculator:");
            
            try
            {
                Console.Write("Type a number as num1\n>>");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Type a number as num2\n>>");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Type a operator\n>>");
                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "-":
                        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "*":
                        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Eerro:divisor is zero!");
                        }
                        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Input format is error!");
                return;
            }
            catch(OverflowException)
            {
                Console.WriteLine("Inputted number is overflow!");
                return;
            }

            
        }
    }
}
