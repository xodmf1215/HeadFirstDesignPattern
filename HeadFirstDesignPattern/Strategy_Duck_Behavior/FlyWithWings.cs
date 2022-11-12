using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern
{
    public class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            System.Console.WriteLine("날고있다!");
        }
    }
}
