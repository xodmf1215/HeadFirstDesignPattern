﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Decorator_Coffe_Order
{
    public class StarbuzzCoffe
    {
        class parent
        {
            protected internal int num = 1;
            public void p()
            {
                System.Console.WriteLine("parent p");
            }
            public virtual void virtual_p()
            {
                System.Console.WriteLine("parent virtual p");
            }
            public void ShowNum()
            {
                System.Console.WriteLine(num);
            }
        }
        class child : parent
        {
            public child()
            {
                num = 2;
            }
            public void p()
            {
                System.Console.WriteLine("child p");
            }
            public override void virtual_p()
            {
                System.Console.WriteLine("child override p");
            }
        }
        public void Run()
        {
            //C#에서 virtual 미표기시 상속 오버라이드 테스트 , 참고로 java는 기본 오버라이드임
            //오버라이딩에 대한 우선 순위가 있다고 생각해야할 듯
            parent a = new child();
            a.p(); //parent p  -> 오버라이드인 경우 명시하지 않으면 변수타입?인 parent 쪽 호출. 자바는 child p 가 나옴
            a.virtual_p(); //child override p
            a.ShowNum(); //2   오버라이드가 아닌 경우 상속 의도한대로 동작, java와 동일
            child b = new child();
            b.virtual_p();

            Beverage beverage = new Espresso();
            System.Console.WriteLine(beverage.getDescription() + "$" + beverage.cost());
            
            Beverage beverage1 = new DarkRoast();
            beverage1 = new Mocha(beverage1);
            beverage1 = new Whip(beverage1);
            System.Console.WriteLine(beverage1.getDescription() + "$" + beverage1.cost());

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Soy(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            System.Console.WriteLine(beverage2.getDescription() + "$" + beverage2.cost());

        }
    }
}
