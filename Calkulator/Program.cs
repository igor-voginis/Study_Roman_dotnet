using System;

namespace Calkulator
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1;
            int number2;
            bool stat = false;
           

            do
            {
                Console.WriteLine("Введите целое число");
                stat = int.TryParse(Console.ReadLine(), out number1);
                if (!stat)
                {
                    Console.WriteLine("Вы ввлели не целое число");
                }
            } while (!stat);

            do
            {
                Console.WriteLine("Введите целое число");
                stat = int.TryParse(Console.ReadLine(), out number2);
                if (!stat)
                {
                    Console.WriteLine("Вы ввлели не целое число");
                }
            } while (!stat);


          
                Console.WriteLine("введите действие которое хотите произвести с этими часлами только (+, -, / или *");
                string operation = Console.ReadLine();

                
           
            int result;
            switch (operation)
            {
                case "+":
                    result = Sum(number1, number2);
                    Console.WriteLine($"результат сложения этих чисел равен {result}");
                    break;

                case "-":
                    result = Minus(number1, number2);
                    Console.WriteLine($"результат вычитания этих чисел равен {result}");
                    break;

                case "/":
                    result = Division(number1, number2);
                    Console.WriteLine($"результат деления этих чисел равен {result}");
                    break;

                case "*":
                    result = Multipl(number1, number2);
                    Console.WriteLine("результат умножения этих чисел равен " + result);
                    break;

                default:
                    Console.WriteLine("вы ввели неверное действие");
                    break;
            }
            


            static int Sum(int number1, int number2)
            {
                return number1 + number2;
            }
            static int Minus(int number1, int number2)
            {
                return number1 - number2;
            }
            static int Multipl(int number1, int number2)
            {
                return number1 * number2;
            }
            static int Division(int number1, int number2)
            {
                return number1 / number2;
            }
        }
    }
}
