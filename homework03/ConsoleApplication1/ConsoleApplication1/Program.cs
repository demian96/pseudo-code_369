using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//호출 할 때 마다 Hello~~ 라고 출력하는 메소드를 Program class안에 추가하시오 
//    public class name
//    {
//        public string name;
//   }
//   public class age
//   {
//       public string age;
//   }
//   public class adress
//   {
//       public string adress;
//   }

namespace ConsoleApplication1

{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("아무거나 입력");
                string line = Console.ReadLine(); // 값을 입력받는 부분!
                if (line == "end") break; // end가 입력되면 무한 루프를 빠져나온다.
                            }

            Console.WriteLine("Hello World");
        }
    }
}