using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class DarkRoast : Baverage
    {
        public DarkRoast(string description) : base(description)
        {
        }

        public override float cost()
        {
            return 3.99f;
        }
    }
}
