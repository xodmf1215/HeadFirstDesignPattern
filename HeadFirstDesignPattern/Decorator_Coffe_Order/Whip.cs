using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Decorator_Coffe_Order
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double cost()
        {
            return beverage.cost() + 0.1;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", 휘핑크림";
        }
    }
}
