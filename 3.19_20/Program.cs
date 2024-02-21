using _3._19_20.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._19_20
{
    //Виртуальный метод.
    class OverrideDemo
    {
        static void Main()
        {
            BaseClass baseOb = new BaseClass();
            DerivedClass dOb1 = new DerivedClass();
            Derived2Class dOb2 = new Derived2Class();
            BaseClass baseRef; // ссылка на базовый класс
            baseRef = baseOb;
            baseRef.Who();
            baseRef = dOb1;
            baseRef.Who();
            baseRef = dOb2;
            baseRef.Who();

            Console.ReadLine();
        }
    }
}
