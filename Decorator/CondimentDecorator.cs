using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CondimentDecorator : Baverage
    {
        protected Baverage baverage;

        public CondimentDecorator(Baverage baverage,String description) : base(description)
        {
            this.baverage = baverage;       
        }

        public CondimentDecorator(string description) : base(description)
        {
        }

        public abstract override float cost();
        public abstract  override String getDescription();

    }
}
