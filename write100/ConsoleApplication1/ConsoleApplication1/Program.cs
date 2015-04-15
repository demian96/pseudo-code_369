using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//숙제: ProcessArray()라는 함수를 작성하여 다음과 같은 문제를 해결하라
//1. 배열에 200부터 짝수 100개를 넣고 출력하시오
//2. 배열에 0부터 홀수 100개를 넣고 출력하시오 
// 예: ProcessArray(시작값, 갯수, 짝수홀수여부)
// 1번문제 ProcessArray(200, 100, true)
// 2번문제 ProcessArray(0, 100, false)

namespace ConsoleApplication1
{
    class Program
    {

		void ProcessArray(int beginIndex, int count, bool isEven)
		{
			// implement here!!
		}

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
  
