using System;
using System.Linq;

namespace adressbook
{
    class Program
    {
        static void Main(string[] args)
        {


            BookRecord bookRecord = new BookRecord(1, "kate", "Беларусь");
            BookRecord bookRecord1 = new BookRecord(2, "vasya", "Мексика");
            BookRecord bookRecord2 = new BookRecord(3, "igor", "Израиль");

                 
           
            bookRecord.GetInfo();
            bookRecord1.GetInfo();
            bookRecord2.GetInfo();

            BookRecord bookRecord3 = new BookRecord();
            bookRecord3.Add();

            bookRecord3.GetInfo();





            //string[] name = new string[] { "kate", "vasya", "igor"};
            //int[] number = new int[] { 1, 2, 3 };
            //string[] country = new string[] {"Беларусь", "Мексика", "Израиль" };

            //for (int i = 3; i < 5; i++)
            //{
            //    Console.WriteLine("введите имя");
            //    string nextName = Console.ReadLine();
            //    name = name.Concat(new string[] {$"{nextName}"}).ToArray();

            //    Console.WriteLine("введите номер");
            //    int nextNumber = Convert.ToInt32(Console.ReadLine());
            //    number = number.Concat(new int[] {nextNumber}).ToArray();

            //    Console.WriteLine("введите страну");
            //    string nextCountru = Console.ReadLine();
            //    country = country.Concat(new string[] { $"{nextCountru}" }).ToArray();

            //}


            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine($"Имя: {name[i]} Номер: {number[i]} Страна: {country[i]}");
            //}


        }
    }
}
