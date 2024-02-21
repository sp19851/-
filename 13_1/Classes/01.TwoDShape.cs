using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1.Classes
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
}
