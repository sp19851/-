using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        // Конструктор, вызываемый по умолчанию.
        //public TwoDShape()  //тот же результат мы получаем если ничего не указываем, так переменные pri_width и pri_height по умолчанию иницируются как 0d;
        //{
        //    Width = Height = 0.0;
        //}
        public TwoDShape()
        {
            
        }

        // Конструктор класса TwoDShape.
        public TwoDShape(double w, double h)
        {
            Width = w;
            Height = h;
        }
        // Сконструировать объект равной ширины и высоты.
        public TwoDShape(double k)
        {
            Width = Height = k;
        }
        public void ShowDim()
        {
            Console.WriteLine("Ширина и высота равны " + Width + " и " + Height);
        }
    }
}
