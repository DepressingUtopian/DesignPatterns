using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Mocha : CondimentDecorator
    {
        public Mocha(Baverage baverage, String description) : base(baverage, description)
        {
        }
        public override String getDescription()
        {
            return this.description + "," + this.baverage.getDescription();
        }
        public override float cost()
        {
            return 7.77f + this.baverage.cost();
        }
    }
}
