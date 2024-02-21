using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2.Classes
{
    //базовый класс
    class TwoDShape
    {
        //приватные переменные базового класса
        double width;
        double height;

        public void ShowDim()
        {
            Console.WriteLine("Ширина и высота равны " + width + " и " + height);
        }
    }
}
