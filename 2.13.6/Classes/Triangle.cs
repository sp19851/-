using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._13_5.Classes
{
    //клас наследник
    class Triangle : TwoDShape
    {
        string style; 
                      

        // Конструктор.
        public Triangle(string s, double w, double h) : base(w, h) //Необходимо вызвать конструктор базового класса, иначе компилятор выдаст ошибку, так как базовый клас содержит явкно указанный конструктор.
        {
            Width = w; 
            Height = h; 
            style = s; 
        }

        //В данном варианте конструктор Triangle() вызывает метод base с параметрами w и h.Это, в свою очередь, приводит к вызову конструктора TwoDShape(),
        //инициализирующего свойства Width и Height значениями параметров w и h. Они больше не инициализируются средствами самого класса Triangle,
        //где теперь остается инициализировать только его собственный член Style, определяющий тип треугольника.
        //Благодаря этому класс TwoDShape высвобождается для конструирования своего подобъекта любым избранным способом.
        //Более того, в класс TwoDShape можно ввести функции, о которых даже не будут подозревать производные классы, что предотвращает нарушение существующего кода.

        public double Area()
        {
            return Width * Height / 2;
        }
        //метод выводит информацию о типе треугольника
        public void ShowStyle()
        {
            Console.WriteLine("Треугольник " + style);
        }
    }
}
