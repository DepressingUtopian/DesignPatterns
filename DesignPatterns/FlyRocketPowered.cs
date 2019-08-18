﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class FlyRocketPowered : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Я лечу на рокете!!!");
        }
    }
}
