using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Observer_Weather_Station
{
    public class WeatherStation
    {
        public void Run()
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentdisplay = new CurrentConditionsDisplay(weatherData);

            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.setMeasurements(80, 65, 30.4f);
            weatherData.setMeasurements(82, 70, 29.2f);
            weatherData.setMeasurements(90, 90, 29.2f);
        }
    }
}
