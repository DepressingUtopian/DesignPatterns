using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns 
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quakeBehavior = new Quake();
            flyBehavior = new FlyWithWings();
        }

        override public void display()
        {
            Console.WriteLine("Я реальная Кряква!");
        }

    }
}
