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
            DescendantClass descendantClass = new DescendantClass();

            descendantClass.Set(2, 3); //методы не вызывают ошибку, так как переменные доступны в классе наследнике
            descendantClass.Show();

            descendantClass.SetK();
            descendantClass.ShowK();
            

            Console.ReadLine();

        }
    }
}
