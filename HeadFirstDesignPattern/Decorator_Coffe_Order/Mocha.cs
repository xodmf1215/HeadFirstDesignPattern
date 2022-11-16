using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Decorator_Coffe_Order
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double cost()
        {
            return beverage.cost() + 0.20;
            
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", 모카";
        }
    }
}
