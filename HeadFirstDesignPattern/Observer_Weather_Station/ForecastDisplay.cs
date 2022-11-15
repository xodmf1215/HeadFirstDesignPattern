using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Observer_Weather_Station
{
    class ForecastDisplay : Observer, DisplayElement
    {
        private WeatherData weatherData;
        private float currentPressure = 29.92f;
        private float lastPressure;
        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            System.Console.WriteLine("Forecast: ");
            if (currentPressure > lastPressure)
            {
                System.Console.WriteLine("Improving weather on the way!");
            }
            else if (currentPressure == lastPressure)
            {
                System.Console.WriteLine("More of the same");
            }
            else if (currentPressure < lastPressure)
            {
                System.Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }
        //디스플레이마다 필요로 하는 데이터가 다르네
        public void update()
        {
            lastPressure = currentPressure;
            currentPressure = weatherData.getpressure();
            // 여기서 display 호출하는게 최선인가 ? MVC 패턴에서 심화할 수 있음
            display();
        }
    }
}
