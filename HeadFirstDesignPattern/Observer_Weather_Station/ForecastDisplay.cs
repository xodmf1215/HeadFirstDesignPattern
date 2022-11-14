using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Observer_Weather_Station
{
    class ForecastDisplay : Observer, DisplayElement
    {
        public void display()
        {
            throw new NotImplementedException();
        }

        public void update(float temp, float humidity, float pressure)
        {
            throw new NotImplementedException();
        }
    }
}
