using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Decorator_Coffe_Order
{
    public abstract class Beverage
    {
        protected String description = "제목 없음";
        
        /* 
         * JAVA에서는 virtual 없어도 오버라이드 되는데, C#에서는 오버라이드가 안된다.. virtural 로 명시해야하고
         * 데코레이터에서도 override 함을 써줘야한다
         */
        public virtual string getDescription()
        {
            return description;
        }
        /*
        public abstract string getDescription();
        */
        public abstract double cost();
    }
}
