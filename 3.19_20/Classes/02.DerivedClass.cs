using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._19_20.Classes
{
    class DerivedClass:BaseClass
    {
        // Переопределить метод Who() в производном классе.
        public override void Who()
        {
            Console.WriteLine("Метод Who() в классе Derivedl");
        }
    }
}
