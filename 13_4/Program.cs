using _13_4.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_4
{
    //модификатор доступа protected
    
    class ProtectedDemo
    {
        static void Main()
        {
            DescendantClass heirClass = new DescendantClass();

            heirClass.Set(2, 3); //методы не вызывают ошибку, так как переменные доступны в классе наследнике
            heirClass.Show();

            heirClass.SetK();
            heirClass.ShowK();
            

            Console.ReadLine();

        }
    }
}
