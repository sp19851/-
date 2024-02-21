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
        string style; //переменная стала закрытой

        // Конструктор.
        public Triangle(string s, double w, double h) 
        {
            Width = w; // Обратите вниамнеи! Происходит инициализация члена базового класса через свойство
            Height = h; // 
            style = s; // инициализировать член класса наследника (производного класса) напрямую через переменную
        }

        public double Area()
        {
            return Width * Height / 2;
        }
        
        public void ShowStyle()
        {
            Console.WriteLine("Треугольник" + style);
        }
    }
}
