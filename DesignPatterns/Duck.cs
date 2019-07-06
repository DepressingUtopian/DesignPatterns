using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuakeBehavior quakeBehavior;

        public void performQuack()
        {
            quakeBehavior.quake();
        }
        public void performFly()
        {
            flyBehavior.fly();
        }
        public void swim()
        {

        }
        public abstract void display();

        public void setFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void setQuackBehavior(QuakeBehavior qb)
        {
            quakeBehavior = qb;
        }
    }
}
