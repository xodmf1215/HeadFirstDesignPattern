using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern
{
    public class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            System.Console.WriteLine("저는 못 날아요");
        }
    }
}
