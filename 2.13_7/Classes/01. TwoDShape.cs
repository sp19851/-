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
        
        double pri_width; 
        double pri_height;

        public double Width
        {
            get { return pri_width; }
            set { pri_width = value < 0 ? -value : value; } 
        }
        public double Height
        {
            get { return pri_height; }
            set { pri_height = value < 0 ? -value : value; }

        }
        //Конструктор, вызываемый по умолчанию.
        public TwoDShape()  
        {
            Width = Height = 0.0;
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
