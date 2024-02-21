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
                             

        // Конструктор, используемый по умолчанию.
        
        public Triangle()
        {
            style = "null";
        }
        // Конструктор для класса Triangle,
        public Triangle(string s, double w, double h) : base(w, h, "треугольник")
        {
            style = s;
        }
        //Сконструировать равнобедренный треугольник,
        public Triangle(double x) : base(x, "треугольник")
        {
            style = "равнобедренный";
        }
        // Сконструировать копию объекта типа Triangle,
        public Triangle(Triangle ob) : base(ob)
        {
            style = ob.style;
        }
        // Переопределить метод Area() для класса Triangle,
        public override double Area()
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
