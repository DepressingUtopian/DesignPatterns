using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface Observer
    {
        /// <summary>
        /// Обновление данных наблюдателя
        /// </summary>
        /// <param name="temperature">Температура</param>
        /// <param name="humidity">Влажность</param>
        /// <param name="pressure">Давление</param>
        void update(float temperature, float humidity,float pressure);
        void remove();
    }
}
