using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 51;
            int b = 50;

            if (a < b) // a가 b보다 작을 경우!
                Console.WriteLine("b가 a보다 큽니다.");
            else if (a == b) // a와 b가 같을 경우!
                Console.WriteLine("a와 b는 서로 같습니다.");
            else // 그 외의 경우!
                Console.WriteLine("a가 b보다 큽니다.");
        }
    }
}