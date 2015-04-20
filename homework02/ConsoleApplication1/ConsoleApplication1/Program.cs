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
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요: ");
            string line = Console.ReadLine();
            
            Console.WriteLine("Hello "+ line);

        }
    }
}
