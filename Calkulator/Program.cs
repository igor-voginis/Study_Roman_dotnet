using System;

namespace Calkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите целое число");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите действие которое хотите произвести с этими часлами только (+, -, / или *");
            string operation = Console.ReadLine();
            int result;
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    Console.WriteLine($"результат сложения этих чисел равен {result}");
                    break;

                case "-":
                    result = number1 - number2;
                    Console.WriteLine($"результат вычитания этих чисел равен {result}");
                    break;

                case "/":
                    result = number1 / number2;
                    Console.WriteLine($"результат деления этих чисел равен {result}");
                    break;

                case "*":
                    result = number1 * number2;
                    Console.WriteLine($"результат умножения этих чисел равен {result}");
                    break;

                default:
                    Console.WriteLine("incorrect symbol");
                    break;
            }
        }
    }
}
