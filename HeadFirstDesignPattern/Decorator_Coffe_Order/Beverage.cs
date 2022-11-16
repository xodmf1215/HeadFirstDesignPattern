using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Decorator_Coffe_Order
{
    public abstract class Beverage
    {
        protected String description = "제목 없음";
        public string getDescription()
        {
            return description;
        }
        public abstract double cost();
    }
}
