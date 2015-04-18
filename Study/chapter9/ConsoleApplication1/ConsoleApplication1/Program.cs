using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    int[] reading = new int[6] { 4, 9, 1, 0, 21, 12 }; 
            // 6개의 Reading 배열 선언, 각각의 방에 4, 9, 1, 0, 21, 12를 순서대로 넣는다.

       //     for (int i = 0; i < reading.Length; i++)
                // int i가 0부터 시작함을 선언하고 i가 reading에서 선언된 배열 길이보다 적을 경우 i에 1을 더하고 다시 처음으로
       //         Console.WriteLine("reading[" + i + "]={0}", reading[i]);
                // 화면에 "reading[ ]" 대괄호 사이에 i 배열 순번의 reading의 값을 넣는다.
       // }


        {
            int[] reading = new int[] { 4, 9, 1, 0, 21, 12 };
            // reaing 배열의 개수를 지정하지 않고 각각의 배열에 4, 9, 1, 0, 21, 12를 배치

            Console.WriteLine("속성: Rank={0}, Length={1}", reading.Rank, reading.Length);
            // reading의 차원 수와 길이를 반환함
            // (?) 왜 rank값과 length값을 변수로 넣지 않았는데 0과 1 대신에 1과 6일 출력되나요?
            // 1과 6이 왜 나왔는지는 알겠는데.. (rank = 차원수/ length = 배열 개수)

            Console.Write("Clear 메소드: ");
            //"clear 메소드" 뒤에 아래의 클리어 값 출력
            // "clear 메소드" 뒤에 아래아래의 console.WriteLine이 연달아 출력

            Array.Clear(reading, 0, 5); // 배열 요소를 0부터 시작하여 5개의 요소를 초기화 시킴
            // Array.Clear(요소를 지울 배열, 시작 인덱스, 지울 요소수);
            //따라서 4, 9, 1, 0, 21은 0이 되고 그 뒤의 배열 값만 선택

            Array.ForEach<int>(reading, new Action<int>(ShowValue));
            // 해당 배열의 각 요소를 가지고 동작(ShowValue)를 수행함
            // Array.ForEach<데이터타입>(동작을 수행할 배열, new Action<데이터타입>(액션);
            //위에 clear에서 지운 배열을 가지고 동작을 수행

            Console.WriteLine();
            // clear에서 지운 배열을 가지고 ForEach에서 어떤 동작을 수행할 지를 체크 한 뒤 결과를 출력
            // Array.Clear + Array.ForEach + Console.WriteLine 이 세트

            Console.Write("Resize 메소드: ");
            // "Resize 메소드" 뒤에 역시 아래아래의 WriteLine이 연달아 출력
            Array.Resize(ref reading, reading.Length + 3);
            // reading 배열의 길이를 3만큼 늘림, Array.Resize(배열의 주소값, 새 배열의 크기);
            //배열의 길이는 3만큼 늘렸지만 배열에 배치된 값이 없으므로 모두 비어 있으므로 0
            Array.ForEach<int>(reading, new Action<int>(ShowValue));
            //위와 동일하게 각 배열의 요소를 가지고 showValue 수행
            Console.WriteLine();
            
            //

            Console.WriteLine("indexOf 메소드: {0}", Array.IndexOf(reading, 12));
            // 배열에서 12란 값을 가지고 있는 요소의 인덱스를 반환함
            // Array.IndexOf(배열, 찾고자 하는 값);
        }

        static void ShowValue(int value) // 동작, value를 받아 그 value를 출력시킴
        {
            Console.Write("{0} ", value);
        }
    }
}