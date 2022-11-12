using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern
{
    /*
     * 네임스페이스 내에서 직접 선언된(즉, 다른 클래스 또는 구조체 내에 중첩되지 않은) 클래스, 레코드 및 구조체는
     * public과 internal 중 하나일 수 있습니다.액세스 한정자가 지정되지 않은 경우 기본값은 internal입니다.
     */
    public abstract class Duck
    {
        /*
         * Class and struct members, including nested classes and structs, have private access by default
         * 기본값은 private 이므로 상속에서 쓰고 싶다면 "protected", "internal", "private protected", "protected internal" 을 사용
         */
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;
        public Duck() { }
        public abstract void display();
        public void performFly()
        {
            flyBehavior.fly();
        }
        public void performQuack()
        {
            quackBehavior.quack();
        }
        public void swim()
        {
            System.Console.WriteLine("모든 오리는 물에 뜹니다. 가짜 오리도 뜨죠");
        }
        public void setFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void setQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
