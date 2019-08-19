using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy 
{
    class MallardDuck : Duck
    {
        /// <summary>
        /// MallardDuck использует класс Quack  для выполнения действия, 
        /// так что при вызове performQuack() ответственность за выполнение возлагается на объект Quack. 
        /// А в качестве реализации  FlyBehavior используется тип FlyWithWings
        /// </summary>
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
