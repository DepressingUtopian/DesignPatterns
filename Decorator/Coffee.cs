using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Coffee
    {
        static void Main(string[] args)
        {
            Baverage baverage = new DarkRoast("Какое-то кофе!");
            baverage = new Milk(baverage,"Молоко!");
            baverage = new Milk(baverage, "Молоко!");
            baverage = new Soy(baverage, "Soy!");
            Console.WriteLine(baverage.getDescription() +"="+ baverage.cost() + "$");

        }
    }
}
