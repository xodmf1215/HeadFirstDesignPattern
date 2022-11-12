using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern
{
    public class DuckSoundMaker
    {
        public DuckSoundMaker()
        {
            quackBehavior = new Quack();
        }
        public QuackBehavior quackBehavior;
        public void makeSound()
        {
            quackBehavior.quack();
        }
    }
}
