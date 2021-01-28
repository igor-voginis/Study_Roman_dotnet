using System;

namespace Metod
{
    class Program
    {
        private static int Sum(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("учебные тесты");
            PrintNumber(256);
            PrintString("строка");
            int result = Sum(4, 7);
            Console.WriteLine(result);


        }
        private static void PrintNumber(int number)
        {
            Console.WriteLine(number);
        }

        private static void PrintString(string str)
        {
            Console.WriteLine(str);
        }
    }
}
