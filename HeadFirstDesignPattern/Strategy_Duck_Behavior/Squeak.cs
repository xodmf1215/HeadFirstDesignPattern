using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern
{
    public class Squeak : QuackBehavior
    {
        public void quack()
        {
            System.Console.WriteLine("삑");
        }
    }
}
