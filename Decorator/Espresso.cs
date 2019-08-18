using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator 
{
    public class Espresso : Baverage
    {
        public Espresso(string description) : base(description)
        {
        }

        public override float cost()
        {
            return 4.44f;
        }
    }
}
