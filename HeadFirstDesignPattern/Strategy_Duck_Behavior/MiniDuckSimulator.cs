using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern
{
    public class MiniDuckSimulator
    {
        public void Run()
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();

            Duck model = new ModelDuck();
            model.performFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();

            DuckSoundMaker dsm = new DuckSoundMaker();
            dsm.makeSound();
        }
    }
}
