using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Factory_Pizza_Order
{
    public abstract class Pizza
    {
        public string name;

        public Dough dough;
        public Sauce sauce;
        public Veggies[] veggies;
        public Cheese cheese;
        public Pepperoni pepperoni;
        public Clams clams;
        /*
        public virtual void prepare()
        {
            System.Console.WriteLine("준비중 : " + name);
            System.Console.WriteLine("토핑뿌리기 : " + name);
            foreach (string topping in toppings)
            {
                System.Console.WriteLine("\t" + topping);
            }
        }*/
        public abstract void prepare();
        public virtual void bake()
        {
            System.Console.WriteLine("175도 25분 굽기");
        }
        public virtual void cut()
        {
            System.Console.WriteLine("피자 사선 자르기");
        }
        public virtual void box()
        {
            System.Console.WriteLine("피자 담기");
        }
        public virtual string getName()
        {
            return name;
        }
    }
}
