using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class HouseBlend : Baverage
    {
        public HouseBlend(string description) : base(description)
        {
        }
        public override float cost()
        {
            return 6.33f;
        }
    }
}
