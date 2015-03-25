using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _369
{
    class Program
    {
     

        static void DrawScreen()
        {
            // 그래픽 : 화면 중앙 상단에 0 출력
            // 그래픽 : 컨베이어 벨트를 출력
            // 그래픽 : 중앙에서부터 3개의 박스를 출력
            // 그래픽 : 중앙 하단에 손가락 끝 출력
            // 개별 박스에 1부터 3까지 순서대로 출력
            // 좌하단에 버튼 : Pass 출력
            // 우하단에 버튼 : Finger 출력
        }

        static void Main(string[] args)
        {
            DrawScreen();
            ///- UI입력이 없는 순수 로직만 만들어본다. 
            // 버튼 Pass 입력 
                // 컨베이어 벨트 이동
                // 개별 박스 1칸 이동
                // 맨 앞의 박스 소멸
                // 맨 뒤에 박스 출력
                // 박스 위에 숫자 출력
                    // 뒤에서 두번째 박스 + 1 숫자 출력
            // 버튼 Finger 입력
                // Move : 손가락이 화면 중앙 컨베이어벨트 위의 박스에 닿을 정도까지 이동
                // 손가락과 박스 충돌 체크
                    // 접촉 > Anmation : 박스가 컨베이어 벨트 너머로 넘어감
                    // 박스 넘버 체크 > 박스 넘버가 3의 배수, 혹은 3이 들어간 숫자인가 체크
                        //박스 넘버가 3의 배수, 혹은 3이 들어간 숫자일 경우 > 화면 중앙 상단 0에 +1
                        //박스 넘버가 3의 배수, 혹은 3이 들어간 숫자가 아닌 경우 > 화면 중앙에 Fail 글자 출력
        }
    }
}
