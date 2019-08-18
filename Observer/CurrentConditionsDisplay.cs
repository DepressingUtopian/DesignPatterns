using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class CurrentConditionsDisplay : Observer,DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;
        public CurrentConditionsDisplay()
        {

        }

        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("CurrentConditionsDisplay");
            Console.WriteLine("Текущее условие: {0}F градусов, {1}% влажность.",temperature,humidity);
            Console.WriteLine("Тепловой индекс: {0}.", ((WeatherData)weatherData).computeHeatIndex(temperature,humidity));
        }
        public void remove()
        {
            this.weatherData.removeObserver(this);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }
    }
}
