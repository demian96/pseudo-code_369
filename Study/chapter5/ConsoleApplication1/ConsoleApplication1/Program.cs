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
            int a = 50;
            int b = 54;

            if (a < b) // 참고: 실행될 문장이 한줄이라면 괄호가 없어도 됨.
                Console.WriteLine("b가 a보다 큽니다.");
            if (a > b)
                Console.WriteLine("a가 b보다 큽니다.");
        }
    }
}