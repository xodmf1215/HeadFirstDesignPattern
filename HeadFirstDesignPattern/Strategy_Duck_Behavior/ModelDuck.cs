using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }
        public override void display()
        {
            System.Console.WriteLine("저는 모형 오리입니다");
        }
    }
}
