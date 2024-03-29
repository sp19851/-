﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1.Classes
{
    //клас наследник
    class Triangle : TwoDShape //Обратите внимание на синтаксис, используемый в классе Triangle для наследования класса
    {
        public string style; //тип треугольника, переменная только в наследнике
        //метод расчитывает площадь треугольника
        public double Area()
        {
            return width * height / 2;
        }
        //метод выводит информацию о типе треугольника
        public void ShowStyle()
        {
            Console.WriteLine("Треугольник " + style);
        }
    }
}
