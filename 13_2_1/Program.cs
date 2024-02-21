using _13_2_1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_3
{
    class Shapes
    {
        static void Main()
        {
            Triangle triangle1 = new Triangle();
            Triangle triangle2 = new Triangle();
            triangle1.Width = 4d; //теперь значение задается не напрямую в переменную,а через свойство
            triangle1.Height = 4d;
            triangle1.style = "равнобедренный"; //а тут непосредтвенно в переменную
            triangle2.Width = 8d;
            triangle2.Height = 12d;
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
