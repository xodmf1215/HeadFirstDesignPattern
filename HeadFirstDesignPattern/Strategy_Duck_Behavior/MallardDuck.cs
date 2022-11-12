using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
        public override void display()
        {
            System.Console.WriteLine("저는 물오리입니다.");
        }
    }
}
