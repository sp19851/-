using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._13_5.Classes
{
    //клас наследник
    class Triangle : TwoDShape
    {
        public string style; //тип треугольника, переменная только в наследнике
                             //метод расчитывает площадь треугольника

        // Конструктор.
        public Triangle(string s, double w, double h) : base(w, h) //Необходимо вызвать конструктор базового класса, иначе компилятор выдаст ошибку, так как базовый клас содержит явкно указанный конструктор.
        {
            Width = w; // инициализировать член базового класса через свойство
            Height = h; // инициализировать член базового класса через свойство
            style = s; // инициализировать член класса наследника (производного класса) напрямую через переменную
        }

        public double Area()
        {
            return Width * Height / 2;
        }
        //метод выводит информацию о типе треугольника
        public void ShowStyle()
        {
            Console.WriteLine("Треугольник " + style);
        }
    }
}
