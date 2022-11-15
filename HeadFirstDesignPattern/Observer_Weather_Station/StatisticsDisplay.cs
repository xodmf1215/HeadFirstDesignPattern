using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Observer_Weather_Station
{
    class StatisticsDisplay : Observer, DisplayElement
    {
        private WeatherData weatherData;
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            System.Console.WriteLine("Avg/Max/Min temperature = " + (tempSum / numReadings) + "/" + maxTemp + "/" + minTemp);
        }

        public void update()
        {
            float temp = weatherData.getTemperature();
            tempSum += temp;
            numReadings++;

            if (temp > maxTemp)
            {
                maxTemp = temp;
            }

            if (temp < minTemp)
            {
                minTemp = temp;
            }
            display();
        }
    }
}
