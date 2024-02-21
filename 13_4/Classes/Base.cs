using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_4.Classes
{
    //базовый класс
    class BaseClass
    {
        //защищенные переменнае базового класса. Будут доступны в классах наследниках
        protected int i, j;

        public void Set(int a, int b)
        {
            i = a; j = b;
        }
        public void Show()
        {
            Console.WriteLine(i + " " + j);
        }
    }
}
