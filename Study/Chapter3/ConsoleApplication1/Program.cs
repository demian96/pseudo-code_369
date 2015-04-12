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
            byte a = 200; //  1 byte  - 255(0xff)
            sbyte b = -126; // 부호 있는 1 byte (절반값만)
            short c = 30000; // 4 byte
            ushort d = 40000; // 부호없는 4byte
            int e = 100000000; // 8byte
            uint f = 1000000000; // 부호없는 8byte
            long g = 1000000000000000000; // 16byte?
            ulong h = 10000000000000000000; // 

            Console.WriteLine("a={0}, b={1}, c={2}, d={3}, e={4}, f={5}, g={6}, h={7}", a, b, c, d, e, f, g, h);

            Console.WriteLine("sizeof byte={0}, sbyte={1}, short={2}, ushort={3}, int={4}, uint={5}, long={6}, ulong={7}", sizeof(byte), sizeof(sbyte), sizeof(short), sizeof(ushort), sizeof(int), sizeof(uint), sizeof(long), sizeof(ulong));

        }
    }
}