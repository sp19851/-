using _2._13_5.Classes;
using _3._13_21.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._13_21
{
    class DynShapes
    {
        static void Main()
        {
            //Объявляем одномерный массив типа TwoDShape
            TwoDShape[] shapes = new TwoDShape[5];
            //заполняем массив ссылками на объекты наших классов
            shapes[0] = new Triangle("прямоугольный", 8.0, 12.0);
            shapes[1] = new Rectangle(10);
            shapes[2] = new Rectangle(10, 4);
            shapes[3] = new Triangle(7.0);
            shapes[4] = new TwoDShape(10, 20, "общая форма");
            //циклом типа for выводим значения массива
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine("Объект — " + shapes[i].Name);
                Console.WriteLine("Площадь равна " + shapes[i].Area());
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
