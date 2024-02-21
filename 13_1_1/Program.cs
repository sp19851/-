using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_1
{
    //базовый класс
    class TwoDShape
    {
        public double width;
        public double height;

        public void ShowDim()
        {
            Console.WriteLine("Ширина и высота равны " + width + " и " + height);
        }
    }

    //клас наследник
    class Triangle : TwoDShape
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
            Console.WriteLine("Треугольник" + style);
        }
    }

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
    class Shapes
    {
        static void Main()
        {
            
            Rectangle rectangle1 = new Rectangle();
            Rectangle rectangle2 = new Rectangle();
            rectangle1.width = 3d;
            rectangle1.height = 5d;
            rectangle2.width = 2d;
            rectangle2.height = 2d;
            Console.WriteLine("Сведения об объекте rectangle1: ");
            rectangle1.ShowDim(); //метод класса родителя
            Console.WriteLine("Rectangle1 является квадратом: "+ rectangle1.IsSquare()); 
            Console.WriteLine("Площадь равна: " + rectangle1.Area());
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Сведения об объекте rectangle2: ");
            rectangle2.ShowDim();//метод класса родителя
            Console.WriteLine("Rectangle1 является квадратом: " + rectangle2.IsSquare());
            Console.WriteLine("Площадь равна: " + rectangle2.Area());
            Console.ReadLine();

        }
    }
}
