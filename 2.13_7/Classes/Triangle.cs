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

        /* Конструктор, используемый по умолчанию.
        Автоматически вызывает конструктор, доступный по умолчанию в классе
        TwoDShape. */
        public Triangle()
        {
            style = "null";
        }
        // Конструктор.
        public Triangle(string s, double w, double h) : base(w, h)
        {
            style = s; // инициализировать член класса наследника (производного класса) напрямую через переменную
        }
        // Сконструировать равнобедренный треугольник.
        public Triangle(double x) : base(x)
        {
            style = "равнобедренный";
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
