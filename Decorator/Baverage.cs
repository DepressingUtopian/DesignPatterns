using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Baverage
    {
        public String description = "Simple Baverage";

        public Baverage(string description)
        {
            this.description = description;
        }

        public virtual String getDescription()
        {
            return this.description;
        }
        abstract public float cost();
      
    }
}
