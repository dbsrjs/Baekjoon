using System;
// 스트링빌더를 사용하기 위함
using System.Text;

namespace While1
{
    class Program
    {
        static void Main(string[] args)
        {
        	// 스트링빌더를 생성해준다.
            StringBuilder answer = new StringBuilder();
            
            // 항상 돌아가는 while문을 만든다.
            while (true)
            {
            	// 입력을 받는다.
                string[] s = Console.ReadLine().Split();
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);
                
                // 만약 a와 b가 모두 0일 경우 break를 통해서 while문을 빠져나간다.
                if (a == 0 && b == 0)
                {
                    break;
                }
                
                // 코드가 여기까지 진행됐다면, a와 b가 전부 0은 아닌 상태이다.
                // a + b 계산 값을 스트링빌더인 answer에 저장한다.
                answer.AppendLine((a + b).ToString());
            }
            // a와 b가 모두 0이었다면 while문에서 빠져나와 여기로 오게 된다.
            // 입력된 계산 값을 모두 출력한다.
            Console.WriteLine(answer);
        }
    }
}