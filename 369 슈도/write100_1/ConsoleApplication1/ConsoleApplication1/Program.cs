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
            int num = 0

            int[] reading = new int[100] { 4, 9, 1, 0, 21, 12 };

            for (int i = 0; i < reading.Length; i++)
                Console.WriteLine("reading[" + i + "]={0}", reading[i]);
        }
    }
}