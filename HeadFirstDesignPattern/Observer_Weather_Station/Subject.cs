using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Observer_Weather_Station
{
    public interface Subject
    {
        public void registerObserver(Observer obs);
        public void removeObserver(Observer obs);
        public void notifyObservers();
    }
}
