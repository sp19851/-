using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_3
{
    //базовый класс
    class TwoDShape
    {
        //приватные переменные базового класса
        double pri_width; //элементы венгерской нотации? не рекомендуется к использованию
        double pri_height;

        public double Width
        {
            get { return pri_width; }
            set { pri_width = value < 0 ? -value : value; } //проверяем устанавливаемое значение избыточно ?
        }
        public double Height
        {
            get { return pri_height; }
            set { pri_height = value < 0 ? -value : value; }
            
        }

        public void ShowDim()
        {
            Console.WriteLine("Ширина и высота равны " + Width + " и " + Height);
        }
    }

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
