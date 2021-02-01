using System;
using System.Collections.Generic;
using System.Text;

namespace adressbook
{
    class BookRecord
    {
        public int _number;
        public string _name;
        public string _country;

        public BookRecord (int number, string name, string country)
        {
            _number = number;
            _name = name;
            _country = country;
        }
        public BookRecord(string name, string country) 
        {
            _name = name;
            _country = country;
        }
        public BookRecord() { }

        public void GetInfo()
        {
            Console.WriteLine("№ " + _number + " Имя " + _name + " Страна " + _country);
        }

        public void Add()
        {
            
            Console.WriteLine("Добавьте новое имя");
            _name = Console.ReadLine();
            Console.WriteLine("Добавьте страну для нового имени");
            _country = Console.ReadLine();
        }
    }
            
}
