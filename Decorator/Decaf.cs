using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Decaf : Baverage
    {
        public Decaf(string description) : base(description)
        {
        }

        public override float cost()
        {
            return 2.55f;
        }
    }
}
