using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Factory_Pizza_Order
{
    public abstract class PizzaStore
    {
        public abstract void OrderPizza(string type);
        public abstract Pizza CreatePizza(string type);
    }
}
