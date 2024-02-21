using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_1.Classes
{
    //класс наследник прямоугольник
    class Rectangle : TwoDShape
    {

        //метод проверяет является ли фигура квадратом и возвращяет соответсвующее логическое значение
        public bool IsSquare()
        {
            if (width == height) return true;
            return false;
        }
        //метод расчитывает площадь прямоугольника
        public double Area()
        {
            return width * height;
        }
    }
}
