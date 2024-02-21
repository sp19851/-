using _2._13_5.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._13_21.Classes
{
    // Класс для прямоугольников, производный от класса TwoDShape.
    class Rectangle : TwoDShape
    {
        
        public Rectangle(double w, double h) : base(w, h, "прямоугольник") { }
        
        public Rectangle(double x) : base(x, "прямоугольник") { }
        
        public Rectangle(Rectangle ob) : base(ob) { }
        
        public bool IsSquare()
        {
            if (Width == Height) return true;
            return false;
        }
        // Переопределить метод Area() для класса Rectangle,
        public override double Area()
        {
            return Width * Height;
        }
    }
}
