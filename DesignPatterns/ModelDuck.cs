using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quakeBehavior = new Quake();
        }

        public override void display()
        {
            Console.WriteLine("Я модель утки!");
        }
    }
}
