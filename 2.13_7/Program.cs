using _2._13_5.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._13_7
{
    internal class Program
    {
        //Добавить дополнительные конструкторы в класс TwoDShape
        class Shapes5
        {
            static void Main()
            {
                //конструкторв производного класса по умолчанию
                Triangle triangle1 = new Triangle();
                //конструкторв производного класса c тремя параметрами
                Triangle triangle2 = new Triangle("прямоугольный", 8.0, 12.0);
                //конструкторв производного класса c одним параметром
                Triangle triangle3 = new Triangle(4.0);
                //присаваеваем одному обекту значение другого
                triangle1 = triangle2;
                Console.WriteLine("Сведения об объекте triangle1: ");
                triangle1.ShowStyle();
                triangle1.ShowDim();
                Console.WriteLine("Площадь равна " + triangle1.Area());
                Console.WriteLine();
                Console.WriteLine("Сведения об объекте t2: ");
                triangle1.ShowStyle();
                triangle1.ShowDim();
                Console.WriteLine("Площадь равна " + triangle1.Area());
                Console.WriteLine();
                Console.WriteLine("Сведения об объекте t3: ");
                triangle3.ShowStyle();
                triangle3.ShowDim();
                Console.WriteLine("Площадь равна " + triangle3.Area());
                Console.WriteLine();

                Console.ReadLine();
            }
        }
    }
}
