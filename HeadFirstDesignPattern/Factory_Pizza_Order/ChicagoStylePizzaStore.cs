using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Factory_Pizza_Order
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            /*
            if (type.Equals("Cheese"))
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new ChicagoStylePepperoniPizza();
            }
            else pizza = null;
            */
            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.name = "뉴욕 스타일 치즈 피자";
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.name = "뉴욕 스타일 조개 피자";
            }
            
            return pizza;

        }

        public override void OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
        }
    }
}
