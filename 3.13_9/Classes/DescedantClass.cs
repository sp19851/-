using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._13_9.Classes
{
    // Создать производный класс.
    class DescedantClass : BaseClass
    {
        new int i;// этот член скрывает член i из базового класса 
        //констуртор
        public DescedantClass(int a, int b)
        {
            base.i = a; // здесь обнаруживается скрытый член из класса А
            i = b; // член i из класса В
        }

        public void Show()
        {
            // Здесь выводится член i из класса А.
            Console.WriteLine("Член i в базовом классе: " + base.i);
            // А здесь выводится член i из класса В.
            Console.WriteLine("Член i в производном классе: " + i);

            //Несмотря на то что переменная экземпляра i в производном классе скрывает переменную i из базового класса А, ключевое слово base разрешает доступ к
            //переменной i, определенной в базовом классе.
            //С помощью ключевого слова base могут также вызываться скрытые методы.
            //Например, в приведенном ниже коде класс DescedantClass наследует класс BaseClass и в обоих классах
            //объявляется метод Show(). А затем в методе Show() класса DescedantClass с помощью ключевого слова base
            //вызывается вариант метода Show(), определенный в классе BaseClass.
        }
    }
}
