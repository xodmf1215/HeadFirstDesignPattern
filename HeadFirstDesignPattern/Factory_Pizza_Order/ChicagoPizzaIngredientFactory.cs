using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Factory_Pizza_Order
{
    public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public override Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public override Clams CreateClams()
        {
            return new FrozenClams();
        }

        public override Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public override Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public override Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public override Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new BlackOlives(), new EggPlant() };
            return veggies;
        }
    }
}
