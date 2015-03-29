using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1;
            int a;
            Console.Write("아무 숫자나 입력하세요.:");
            a1 = Console.ReadLine();
            a = Convert.ToInt32(a1);
            Console.WriteLine(a);
        }
    }
}
