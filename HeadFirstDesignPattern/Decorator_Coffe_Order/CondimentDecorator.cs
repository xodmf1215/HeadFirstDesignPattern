using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Decorator_Coffe_Order
{
    //Beverage 객체가 들어갈 곳에 들어갈 수 있음 : Beverage 확장
    public abstract class CondimentDecorator : Beverage
    {
        Beverage beverage;
        public abstract string getDescription();
    }
}
