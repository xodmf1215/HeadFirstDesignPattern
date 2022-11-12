using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern
{
    public class Quack : QuackBehavior
    {
        public void quack()
        {
            System.Console.WriteLine("꽥");
        }
    }
}
