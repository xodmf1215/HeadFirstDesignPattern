using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern
{
    public class FlyRocketPowered : FlyBehavior
    {
        public void fly()
        {
            System.Console.WriteLine("로켓 추진으로 날아갑니다");
        }
    }
}
