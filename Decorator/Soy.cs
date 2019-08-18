using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Soy : CondimentDecorator
    {
        public Soy(Baverage baverage, String description) : base(baverage, description)
        {
        }
        public override String getDescription()
        {
            return this.description + "," + this.baverage.getDescription();
        }
        public override float cost()
        {
            return 3.23f +  this.baverage.cost();
        }
    }
}
