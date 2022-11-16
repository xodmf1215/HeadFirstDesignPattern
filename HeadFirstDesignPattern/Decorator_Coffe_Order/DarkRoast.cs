using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Decorator_Coffe_Order
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "다크 로스트 커피";
        }
        public override double cost()
        {
            return 0.99;
        }
    }
}
