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
        /// Делегирование flyBehavior
        /// Каждый объект Duck содержит ссылку на реализацию интерфейса FlyBehavior
        /// </summary>
        protected FlyBehavior flyBehavior;

        /// <summary>
        /// Делегирование quakeBehavior
        /// Каждый объект Duck содержит ссылку на реализацию интерфейса QuackBehavior
        /// </summary>
        protected QuakeBehavior quakeBehavior;

        /// <summary>
        /// Объект Duck делегирует поведение объекту, на который ссылается quackBehavior
        /// </summary>
        public void performQuack()
        {
            quakeBehavior.quake();
        }

        /// <summary>
        /// Объект Duck делегирует поведение объекту, на который ссылается  flyBehavior
        /// </summary>
        public void performFly()
        {
            flyBehavior.fly();
        }
        /// <summary>
        /// Дополнительное поведение
        /// </summary>
        public void swim()
        {

        }
        /// <summary>
        /// Отображение объекта
        /// </summary>
        public abstract void display();

        /// <summary>
        /// Присвоение объекта FlyBehavior для делегирования.
        /// </summary>
        /// <param name="fb">Делегируемый FlyBehavior</param>
        public void setFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }
        /// <summary>
        /// Присвоение объекта QuakeBehavior для делегирования.
        /// </summary>
        /// <param name="qb">Делегируемый QuakeBehavior</param>
        public void setQuackBehavior(QuakeBehavior qb)
        {
            quakeBehavior = qb;
        }
    }
}
