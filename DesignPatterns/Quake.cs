using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Quake : QuakeBehavior
    {
        public void quake()
        {
            Console.WriteLine("Квааак!");
        }
    }
}
