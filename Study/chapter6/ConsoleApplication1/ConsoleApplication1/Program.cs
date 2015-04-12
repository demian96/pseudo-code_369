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
            int num = 1;

            while (num <= 11)
                Console.WriteLine("num: {0}", num++);
        }
    }
}