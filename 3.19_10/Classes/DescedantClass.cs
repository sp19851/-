using _3._19_10.Classes;
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
        // Здесь скрывается метод Show() из класса А. Обратите
        // внимание на применение ключевого слова new.
        new public void Show()
        {
            base.Show(); // здесь вызывается метод Show() из класса BaseClass
                         // далее выводится член i из класса DescedantClass
            Console.WriteLine("Член i в производном классе: " + i);
        }
    }
}
