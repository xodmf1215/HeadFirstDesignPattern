using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern
{
    public class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            System.Console.WriteLine("<<조용>>");
        }
    }
}
