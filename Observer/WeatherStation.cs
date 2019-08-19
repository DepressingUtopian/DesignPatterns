using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{

    /// <summary>
    /// Главный класс программы
    /// Служит для проверки работоспособности классов
    /// </summary>
    class WeatherStation
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            //Инициализация наблюдателей
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            //Обновление данных
            weatherData.setMeasurements(80,45,34.5f);
            //Удаление одного из наблюдателей
            statisticsDisplay.remove();
            weatherData.setMeasurements(45,34,37.6f);
            weatherData.setMeasurements(49,45,38.5f);
        }
        
    }
}
