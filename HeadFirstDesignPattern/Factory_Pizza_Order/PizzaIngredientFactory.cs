using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Factory_Pizza_Order
{
    public abstract class PizzaIngredientFactory
    {
        public abstract Dough CreateDough();
        public abstract Sauce CreateSauce();
        public abstract Cheese CreateCheese();
        public abstract Veggies[] CreateVeggies();
        public abstract Pepperoni CreatePepperoni();
        public abstract Clams CreateClams();
    }
}
