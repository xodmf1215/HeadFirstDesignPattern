using System;

namespace HeadFirstDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //MiniDuckSimulator strategy = new MiniDuckSimulator();
            //strategy.Run();

            Observer_Weather_Station.WeatherStation observer = new Observer_Weather_Station.WeatherStation();
            observer.Run();
        }
    }
}
