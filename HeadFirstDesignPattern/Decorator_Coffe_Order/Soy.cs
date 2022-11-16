using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Decorator_Coffe_Order
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double cost()
        {
            return beverage.cost() + 0.15;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", 두유";
        }
    }
}
