using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck mallatd = new MallardDuck();
            mallatd.performQuack();
            mallatd.performFly();

            Duck model = new MallardDuck();
            model.performFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();
           
        }
    }
}
