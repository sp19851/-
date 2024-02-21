using _3._13_9.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._13_9
{
    internal class Program
    {
        //Применение ключевого слова base для преодоления
        // препятствия, связанного с сокрытием имен.
        class UncoverName
        {
            static void Main()
            {
                DescedantClass ob = new DescedantClass(1, 2);
                ob.Show();
                Console.ReadLine();
            }
        }
    }
}
