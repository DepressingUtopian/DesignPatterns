using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Duck
    {

        /// <summary>
        /// 
        /// </summary>
        protected FlyBehavior flyBehavior;

        /// <summary>
        /// 
        /// </summary>
        protected QuakeBehavior quakeBehavior;

        /// <summary>
        /// 
        /// </summary>
        public void performQuack()
        {
            quakeBehavior.quake();
        }

        /// <summary>
        /// 
        /// </summary>
        public void performFly()
        {
            flyBehavior.fly();
        }
        /// <summary>
        /// 
        /// </summary>
        public void swim()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        public abstract void display();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fb"></param>
        public void setFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="qb"></param>
        public void setQuackBehavior(QuakeBehavior qb)
        {
            quakeBehavior = qb;
        }
    }
}
