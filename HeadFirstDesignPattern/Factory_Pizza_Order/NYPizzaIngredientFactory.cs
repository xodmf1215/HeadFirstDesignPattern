using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Factory_Pizza_Order
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public override Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public override Clams CreateClams()
        {
            return new FreshClams();
        }

        public override Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public override Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public override Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public override Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new Garlic(), new Onion() };
            return veggies;
        }
    }
}
