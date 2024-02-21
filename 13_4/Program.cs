using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_4
{
    //модификатор доступа protected
    
    //базовый класс
    class BaseClass
    {
        //защищенные переменнае базового класса. Будут доступны в классах наследниках
        protected int i,j;

        public void Set(int a,int b)
        {
            i = a; j = b;
        }
        public void Show()
        {
            Console.WriteLine(i + " " + j);
        }
    }

    //клас наследник
    class HeirClass : BaseClass
    {
        int k; //закрытая переменная
        public void SetK()
        {
            k = i*j; //класс наследник имеет доступ к переменным класса родителя
        }
        public void ShowK() 
        {
            Console.WriteLine("k = " + k);
        }
    }



    class ProtectedDemo
    {
        static void Main()
        {
            HeirClass heirClass = new HeirClass();

            heirClass.Set(2, 3); //методы не вызывают ошибку, так как переменные доступны в классе наследнике
            heirClass.Show();

            heirClass.SetK();
            heirClass.ShowK();
            

            Console.ReadLine();

        }
    }
}
