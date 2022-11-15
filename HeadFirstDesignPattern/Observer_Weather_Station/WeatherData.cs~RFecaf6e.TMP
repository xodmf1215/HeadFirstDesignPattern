using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Observer_Weather_Station
{
    public class WeatherData : Subject
    {
        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;
        public WeatherData()
        {
            observers = new List<Observer>();
        }
        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }
        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void notifyObservers()
        {
            foreach(Observer observer in observers)
            {
                observer.update(temperature, humidity, pressure);
            }
        }

        public void registerObserver(Observer obs)
        {
            observers.Add(obs);
        }

        public void removeObserver(Observer obs)
        {
            observers.Remove(obs);
        }

    }
}
