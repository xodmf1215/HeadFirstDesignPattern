using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Decorator_Coffe_Order
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "에스프레소";
        }
        public override double cost()
        {
            return 1.99;
        }
    }
}
