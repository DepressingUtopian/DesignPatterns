using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class MuteQuake : QuakeBehavior
    {
        public void quake()
        {
            Console.WriteLine("<< Тишина... >>");
        }
    }
}
