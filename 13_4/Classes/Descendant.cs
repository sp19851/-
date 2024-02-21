using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_4.Classes
{
    //клас наследник
    class DescendantClass : BaseClass
    {
        int k; //закрытая переменная
        public void SetK()
        {
            k = i * j; //класс наследник имеет доступ к переменным класса родителя
        }
        public void ShowK()
        {
            Console.WriteLine("k = " + k);
        }
    }
}
