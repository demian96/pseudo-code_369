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
        int m_hp = 0; // 공용 변수(저장소)이므로 이곳에 최종 결과 값을 저장하도록 한다.
        // 초기값이 0이면 처음부터 가진 값이 없으므로 어디선가 초기값을 채워주도록 한다. 
        
        public void setHp(int hp)
        {
            m_hp = hp; //파라메터 hp로 받은 값을 헌터의 m_hp에 덮어쓴다. 
        }
        
        public void sap()
        {
            int down = m_hp - 10; // down이라는 임시 변수에 현재 hp에서 10을 뺀 나머지를 저장한다.
            //이제 나머지 값을 헌터의 멤버변수에 저장하도록 해야 반영이 된다.
            m_hp = down; // down의 값으로 m_hp의 값을 덮어 쓴다. 
            
        }

        public void sleep()
        {
            
            int up = m_hp + 5; // up이라는 임시 변수에 현재 hp에서 5를 더한 결과값을 저장한다.
            // 이제 올라간 값을 헌터의 멤버 변수에 저장해야 반영이 된다.
            m_hp = up; // m_hp의 값을 up으로 덮어쓴다. 
        }     
   
        // get을 하기 때문에 리턴형이 필요하다. 
        //public void get_hp()
        public int get_hp() // hp는 int형이기 때문에 리턴형 int가지도록 정의 한다. 
        {
            //int get_hp=0;
            //get_hp = sum;
            //이 sum을 합을 구하는 함수로 정의하고 싶은데 그 부분을 잘 모르겠어요
            
            // m_hp에 위의 함수들(sap, sleep) 에서 이미 값을 반영 했기 때문에 단순 리턴만 해주면 된다. 
            return m_hp;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            hunter bot = new hunter();
            bot.setHp(100); // bot의 hp는 100으로 지정한다. 
            bot.sap();
            bot.sap();
            bot.sap();
            bot.sleep();
            
            // 남은 값을 받아서 화면에 출력하는 방법
            int leftHp = bot.get_hp();        
            Console.WriteLine("남은 체력 =",leftHp);
            
            // 바로 함수를 호출하여 화면에 출력하는 방법
            Console.WriteLine("남은 저질 체력=", bot.get_hp());
        }
       
    }

}
