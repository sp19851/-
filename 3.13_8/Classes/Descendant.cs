using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._13_8.Classes
{
    // Производный класс.
    class DescendantClass :BaseClass
    {
        new int i; // Класс-наследник содержит такую же переменную, что и в базовом классе. В таком случае член класса-наследника скрывает член i из класса А. Важно здесь ключевое слово new не является иницизатором нового экземпляра класса. 
        //В данном случае new обосзначает, что програмист осознано скрывает элемент класса. Без указанного ключевого слова, компилятор выведет предупреждение
        //"DescendantClass.i" скрывает наследуемый член "BaseClass.i". Если скрытие было намеренным, используйте ключевое слово new.

        //конструктор
        public DescendantClass(int b)
        {
            i = b; // член i в классе В
        }
        public void Show()
        {
            Console.WriteLine("Член i в производном классе: " + i);
        }
    }
}
