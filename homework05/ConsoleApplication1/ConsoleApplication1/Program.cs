using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//헌터 래원 = new 헌터()  최초 체력은 100  한번 삽질 할 때마다 체력은 20씩 소모  
//한번 잠자기 할 때 체력은 10씩 회복   삽질 5번과 잠자기 1번을 한다 남을 체력을 출력

namespace ConsoleApplication1
{
    class won
    {
        int m_hp = 100;

        public void sap()
          {
            int lefthp = m_hp - 20;
            m_hp = lefthp;
          }
        public void sleep()
          {
            int up = m_hp +10;
            m_hp = up;
           }
        public void gethp()
        {
            int gethp = m_hp;
            m_hp = gethp;
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            won bot = new won();
            bot.sap();
            bot.sap();
            bot.sap();
            bot.sap();
            bot.sap();
            bot.sleep();
            bot.gethp();

            int hp = bot.gethp;
                        
           Console.WriteLine("남은 체력:", hp);
        }
     }
}