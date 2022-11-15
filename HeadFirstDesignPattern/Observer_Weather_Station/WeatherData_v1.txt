using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Observer_Weather_Station
{
    //이 클래스도 캡슐화 안됐다
    public class WeatherData_v1
    {
        //바뀌는 부분 캡슐화가 안됐다
        //실행중에 디스플레이 추가 제거 불가능
        //새로운 디스플레이 항목 추가될 때마다 코드 변경 필요
        //인터페이스가 아닌 구체적인 구현 바탕
        private CurrentConditionsDisplay currentConditionDisplay = new CurrentConditionsDisplay();
        private StatisticsDisplay statisticsDisplay = new StatisticsDisplay();
        private ForecastDisplay forecastDisplay = new ForecastDisplay();
        private float temperature;
        private float humidity;
        private float pressure;
        public void measurementsChanged()
        {
            float temp = getTemperature();
            float humidity = getHumidity();
            float pressure = getPressure();
            //디스플레이들은 공통적인 인터페이스를 사용하고 있는 것 같다
            //디스플레이 추가(변경가능)가능하므로 캡슐화 해야함
            currentConditionDisplay.update(temp, humidity, pressure);
            statisticsDisplay.update(temp, humidity, pressure);
            forecastDisplay.update(temp, humidity, pressure);
        }
        public float getTemperature()
        {
            return 1.0f;
        }
        public float getHumidity()
        {
            return 1.0f;
        }
        public float getPressure()
        {
            return 1.0f;
        }
    }
}
