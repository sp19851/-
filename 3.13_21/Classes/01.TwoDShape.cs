using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2._13_5.Classes
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

        public string Name { get; set; } //Обратите внимание тут используется автоматическое свойство


        // Конструктор по умолчанию,
        public TwoDShape()
        {
            Width = Height = 0.0; //напоминаю, что данную строчку можно опустить
            Name = "null";
        }

        // Параметризированный конструктор.
        public TwoDShape(double w, double h, string n)
        {
            Width = w;
            Height = h;
            Name = n;
        }
        // Сконструировать объект равной ширины и высоты,
        public TwoDShape(double x, string n)
        {
            Width = Height = x;
            Name = n;
        }
        // Сконструировать копию объекта TwoDShape.
        public TwoDShape(TwoDShape ob)
        {
            Width = ob.Width;
            Height = ob.Height;
            Name = ob.Name;
        }
        public void ShowDim()
        {
            Console.WriteLine("Ширина и высота равны " + Width + " и " + Height);
        }
        //тот самый виртуальный метод базового класса. Предполагается, что все классы-наследники будут его перепоределять для расчета площади, исходя из их особенностей.
        public virtual double Area()
        {
            Console.WriteLine("Метод Area() должен быть переопределен");
            return 0.0;
        }
    }
}
