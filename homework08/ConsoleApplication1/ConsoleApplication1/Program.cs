using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//체력을 가지는 헌터 클래스를 구현한다
//헌터는 삽질 수면 매소드를 가진다
//삽질을 하면 헌터는 체력 십이 감소한다.
//수면을 취하면 체력이 오 증가한다.
//현재 체력을 반환하는 갯체력 매소드를 구현한다.
//삽질 세번하고 한번 수면한다음 남은 체력을 화면에 출력하시오

namespace ConsoleApplication1
{
    class hunter
    {
        int m_hp = 0;

        public void sap()
        {
            int down = m_hp - 10;
        }

        public void sleep()
        {
            int up = m_hp + 5;
        }     
   
        public void get_hp()
        {
            int get_hp=0;
            get_hp = sum;
            //이 sum을 합을 구하는 함수로 정의하고 싶은데 그 부분을 잘 모르겠어요
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            hunter bot = new hunter();
            bot.sap();
            bot.sap();
            bot.sap();
            bot.sleep();
            bot.get_hp();      

            Console.WriteLine("남은 체력 =",sum);
        }
       
    }

}