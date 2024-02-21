using _3._13_8.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._13_8
{
    //Пример сокрытия имени с наследственной связью.
    class NameHiding
    {
        static void Main()
        {
            DescendantClass ob = new DescendantClass (2);
            ob.Show();

            Console.ReadLine();
        }
    }
}
