using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2_1.Classes
{
    //клас наследник
    class Triangle : TwoDShape
    {
        public string style; //тип треугольника, переменная только в наследнике
                             //метод расчитывает площадь треугольника
        public double Area()
        {
            return Width * Height / 2;
        }
        //метод выводит информацию о типе треугольника
        public void ShowStyle()
        {
            Console.WriteLine("Треугольник" + style);
        }
    }
}
