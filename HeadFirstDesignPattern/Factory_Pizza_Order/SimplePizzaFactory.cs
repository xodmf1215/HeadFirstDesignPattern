using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Factory_Pizza_Order
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza;
            if (type.Equals("cheese")) pizza = new NYStyleCheesePizza();
            else if (type.Equals("pepperoni")) pizza = new NYStylePepperoniPizza();
            else pizza = null;
            return pizza;
        }
    }
}
