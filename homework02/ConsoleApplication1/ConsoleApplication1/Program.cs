using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//이름을 입력받아 "Hello" 이름을 출력하는 함수 제작

namespace ConsoleApplication1
{
    class Program
    {
        // 이게 메소드(함수) 임
        void HelloWorld(string name)
        {
            Console.WriteLine("Hello~ " + name);
        }
        
        static void Main(string[] args)
        {
            HelloWorld("Park");
            HelloWorld("Kim");
        }
    }
}
