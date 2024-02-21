using _3._13_9.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._19_10
{
    //Вызвать скрытый метод.
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
//Как видите, в выражении base.Show() вызывается вариант метода Show() из
//базового класса. Обратите также внимание на следующее: ключевое слово new
//используется в приведенном выше коде с целью сообщить компилятору о том, что
//метод Show(), вновь объявляемый в производном классе DescedantClass, намеренно скрывает
//другой метод Show(), определенный в базовом классе.