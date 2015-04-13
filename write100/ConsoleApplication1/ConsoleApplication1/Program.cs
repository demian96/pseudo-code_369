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
            int[] reading = new int[100]; // 100개의 reading 배열 선언

            for (int i = 0; i < reading.Length; ++i) 
                // i는 0으로 선언,reading 배열의 Length가 위에서 선언된 배열 길이보다 작을 경우 +1씩 반복하여 배열의 위치를 지정
			{
				reading[i] = i+1; // i begin with 0 
			}

           for (int b = 0; b < reading.Length; b++) 
               // 0부터 시작하여 reading의 length가 위에서 선언된 배열 길이보다 작을 경우 +1씩 반복
               
               //++i 와 b++ 의 차이를 모르겠음
               //답: b++은 나중에 1더하라, ++b 먼저 1더해라 
			{              
               Console.WriteLine(reading[b]); // 변수 b의 값을 출력
			}

               
        }
    }
}
  
