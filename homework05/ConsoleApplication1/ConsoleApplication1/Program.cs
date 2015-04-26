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
        int hp = 100;

        public void sap();
          {int i = hp - 20}
        public void sleep();
          {int j = hp +10}
        
        static void Main(string[] args)
        {
            won bot = new won();
            bot.sap();
            bot.sap();
            bot.sap();
            bot.sap();
            bot.sap();
            bot.sleep();
        }
        
    }
}
