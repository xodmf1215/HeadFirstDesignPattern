using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Observer_Weather_Station
{
    public interface Observer
    {
        //측정치를 직접 전달하는게 상태 갱신하는 가장 간단한 방법일까?
        // 애플리케이션의 이 부분이 나중에 바뀔 가능성이 있다면 변경사항을 캡슐화했다고 할 수 있나? 또는 코드를 직접 여러 군데 수정해야 하나??
        //public void update(float temp, float humidity, float pressure);
        //풀링으로 바꾸기
        public void update();
    }
}
