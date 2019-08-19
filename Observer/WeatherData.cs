using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class WeatherData : Subject
    {
        //Список наблюдателей
        private ArrayList observers;

        private float temperature;
        private float humidity;
        private float preassure;

        public WeatherData()
        {
            this.observers = new ArrayList();
        }
        public void registerObserver(Observer observer)
        {
            this.observers.Add(observer);
        }
        public void removeObserver(Observer observer)
        {
            int i = observers.IndexOf(observer);
            if (i >= 0)
            {
                observers.RemoveAt(i);
            }
        }
        public void notifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                Observer observer = (Observer)this.observers[i];
                observer.update(temperature, humidity, preassure);
            }
        }

        /// <summary>
        /// Оповещение об изменениях
        /// </summary>
        public void measurementsChanged()
        {
            notifyObservers();
        }

        /// <summary>
        /// Присвоение новых данных
        /// </summary>
        /// <param name="temperature">Температура</param>
        /// <param name="humidity">Влажность</param>
        /// <param name="preassure">Давление</param>
        public void setMeasurements(float temperature,float humidity,float preassure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.preassure = preassure;
            measurementsChanged();
        }

        /// <summary>
        ///Вычисление теплового индекса
        /// </summary>
        /// <param name="t">Температура</param>
        /// <param name="rh">Влажность</param>
        /// <returns>Тепловой индекс</returns>
        public float computeHeatIndex(float t, float rh)
        {
            float index = (float)((16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh) +
                (0.00941695 * (t * t)) + (0.00728898 * (rh * rh)) +
                (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) +
                (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 *
                (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) +
                (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) +
                0.000000000843296 * (t * t * rh * rh * rh)) -
                (0.0000000000481975 * (t * t * t * rh * rh * rh)));
            return index;
        }

    }
}
