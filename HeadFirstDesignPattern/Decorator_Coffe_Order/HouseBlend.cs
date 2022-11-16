using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Decorator_Coffe_Order
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "하우스 블렌드 커피";
        }
        public override double cost()
        {
            return 0.89;
        }
    }
}
