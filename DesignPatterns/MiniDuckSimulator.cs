using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{

    /// <summary>
    /// Главный класс программы
    /// Служит для проверки работоспособности классов
    /// </summary>
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck mallatd = new MallardDuck();
            mallatd.performQuack();
            mallatd.performFly();

            Duck model = new MallardDuck();
            model.performFly();
            //Динамическое изменение объекта 
            model.setFlyBehavior(new FlyRocketPowered()); 
            model.performFly();
           
        }
    }
}
