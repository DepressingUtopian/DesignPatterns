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

        /// <summary>
        /// В описании должны содержаться не только название напитка (допустим, «Dark Roast»), 
        /// но и все дополнения — например, «Dark Roast, Milk». Таким образом, мы сначала получаем описание, 
        /// делегируя вызов декорируемому объекту, а затем присоединяем к нему строку «, Milk».
        /// </summary>
        /// <returns>Описание</returns>
        public override String getDescription()
        {
            return this.description +","+ this.baverage.getDescription();
        }

        /// <summary>
        /// Теперь необходимо вычислить стоимость.
        /// Сначала вызов делегируется декорируемому объекту, а затем стоимость прибавляется к результату.
        /// </summary>
        /// <returns>Цена</returns>
        public override float cost()
        {
            return 6.55f + this.baverage.cost();
        }
    }
}
