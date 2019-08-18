using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Milk : CondimentDecorator
    {
        public Milk(Baverage baverage, String description) : base(baverage, description)
        {
        }
        public override String getDescription()
        {
            return this.description +","+ this.baverage.getDescription();
        }
        public override float cost()
        {
            return 6.55f + this.baverage.cost();
        }
    }
}
