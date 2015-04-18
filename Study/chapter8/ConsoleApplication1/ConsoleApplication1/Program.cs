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
            int[] reading = new int[6] { 4, 9, 1, 0, 21, 12 }; //reading 배열을 6개 선언하고 4,9,1,0,21,12를 각각의 배열에 배치

            for (int i = 0; i < reading.Length; i++) // for 반복문을 통해 배열의 위치를 지정, 선언된 배열의 수만큼 반복
                Console.WriteLine("reading[" + i + "]={0}", reading[i]); // 위에서 지정한 i위치의 숫자를 출력
        }
    }
}