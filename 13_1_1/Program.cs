using _13_1_1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_1
{
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
