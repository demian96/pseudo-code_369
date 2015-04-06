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
            int[] arr = { 1, 2, 5, 7, 4, 9, 8, 10, 4, 7, 11 };

            foreach (int i in arr)
                Console.WriteLine("i: {0}", i);
        }
    }
}