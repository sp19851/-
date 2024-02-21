using _3._19_11.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._19_11
{
    internal class Program
    {
        //Продемонстрировать порядок вызова конструкторов.
        class OrderOfConstruction
        {
            static void Main()
            {
                DescedantClass2 с = new DescedantClass2 ();
                Console.ReadLine();

                //Как видите, конструкторы вызываются по порядку выведения их классов.
            }
        }
    }
}
