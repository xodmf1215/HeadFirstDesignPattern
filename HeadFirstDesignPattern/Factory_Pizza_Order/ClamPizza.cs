using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Factory_Pizza_Order
{
    public class ClamPizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;
        public ClamPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }
        public override void prepare()
        {
            System.Console.WriteLine("준비중 : " + name);
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            clams = ingredientFactory.CreateClams();
        }
    }
}
