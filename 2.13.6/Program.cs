using _2._13_5.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._13._6
{
    class Shapes4
    {
        static void Main()
        {
            Triangle triangle1 = new Triangle("равнобедренный", 4.0, 4.0);
            Triangle triangle2 = new Triangle("прямоугольный", 8.0, 12.0);
            Console.WriteLine("Сведения об объекте t1: ");
            triangle1.ShowStyle();
            triangle1.ShowDim();
            Console.WriteLine("Площадь равна " + triangle1.Area());
            Console.WriteLine();
            Console.WriteLine("Сведения об объекте t2: ");
            triangle2.ShowStyle();
            triangle2.ShowDim();
            Console.WriteLine("Площадь равна " + triangle2.Area());

            Console.ReadLine();
        }
    }
}
