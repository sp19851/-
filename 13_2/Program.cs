using _13_2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2
{
    //этот пример при компиляции вызовет ошибку
   
    class Shapes
    {
        static void Main()
        {
            Triangle triangle1 = new Triangle();
            Triangle triangle2 = new Triangle();
            triangle1.width = 4d;
            triangle1.height = 4d;
            triangle1.style = "равнобедренный";
            triangle2.width = 8d;
            triangle2.height = 12d;
            triangle2.style = "прямоугольный";
            Console.WriteLine("Сведения об объекте triangle1: ");
            triangle1.ShowStyle();
            triangle1.ShowDim();
            Console.WriteLine("Площадь равна: " + triangle1.Area());
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Сведения об объекте triangle2: ");
            triangle2.ShowStyle();
            triangle2.ShowDim();
            Console.WriteLine("Площадь равна: " + triangle2.Area());

            Console.ReadLine();

        }
    }
}
