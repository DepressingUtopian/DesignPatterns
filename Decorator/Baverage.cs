using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{

    /// <summary>
    /// Абстрактный класс компонента.
    /// </summary>
    public abstract class Baverage
    {
        //Описание по умолчанию
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
