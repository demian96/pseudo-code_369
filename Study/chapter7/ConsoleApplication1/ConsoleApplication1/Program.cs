using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// namespace ConsoleApplication1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int sum = 0;

//            while (true)
//           {
//                Console.Write("수를 입력하세요: ");
//                string line = Console.ReadLine(); // 값을 입력받는 부분!
//                if (line == "end") break; // end가 입력되면 무한 루프를 빠져나온다.
//                sum += int.Parse(line); // 문자열을 숫자로 변환한다!
//            }
//
//            Console.WriteLine("지금까지 입력된 수를 모두 더합니다: " + sum);
//        }
//    }
//}

//namespace ConsoleApplication1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int num = 0;

//            while (num < 100) // num보다 100이 크면 계속 반복
//            {
//                if (num == 40) break; // num이 40이면 break로 인해 반복 탈출
//                Console.WriteLine("num: " + num);
//                num++; // num의 값 1 증가
//            }
//        }
//    }
//}


namespace ConsoleApplication1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 1; i <= 50; i++)
//            {
//                if (i % 2 == 1) continue;
//                Console.WriteLine("i: " + i);
//            }
//        }
//    }
//}

 
{
    class Program
    {
        static void Main(string[] args)
        {


//        {
//            int sum = 0;

//            while (true)
//           {
//                Console.Write("수를 입력하세요: ");
//                string line = Console.ReadLine(); // 값을 입력받는 부분!
//                if (line == "end") break; // end가 입력되면 무한 루프를 빠져나온다.
//                sum += int.Parse(line); // 문자열을 숫자로 변환한다!
//            }
//
//            Console.WriteLine("지금까지 입력된 수를 모두 더합니다: " + sum);
//        }
//
//        {
//            int num = 0;

//            while (num < 100) // num보다 100이 크면 계속 반복
//            {
//                if (num == 40) break; // num이 40이면 break로 인해 반복 탈출
//                Console.WriteLine("num: " + num);
//                num++; // num의 값 1 증가
//            }
//        }

//        {
//            for (int i = 1; i <= 50; i++)
//            {
//                if (i % 2 == 1) continue;
//                Console.WriteLine("i: " + i);
//            }
//        }


		{	
            int num = 0;

            while (num < 100) // num보다 100이 크면 계속 반복
            {
                if (num == 40) goto EXIT; // num이 40이면 break로 인해 반복 탈출
                Console.WriteLine("num: " + num);
                num++; // num의 값 1 증가
            }

        EXIT: // EXIT 레이블!
            Console.WriteLine("탈출!");
        }
		}
    }
}
