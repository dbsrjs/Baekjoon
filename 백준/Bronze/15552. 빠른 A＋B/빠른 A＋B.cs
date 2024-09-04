using System;
// StringBuilder를 사용하기 위해서.
using System.Text;

namespace for문4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 스트링빌더 answer 선언
            StringBuilder answer = new StringBuilder();

            // 테스트케이스 개수 입력 받음
            int t = int.Parse(Console.ReadLine());
            
            // 더하기 때 사용할 int를 배열로 생성함
            int[] a = new int[t];
            int[] b = new int[t];

            for (int i = 0; i < t; i++)
            {
                // 숫자를 입력받고 공백을 기준으로 나눠 담을 수 있게 문자열 배열을 선언한다.
                string[] s = Console.ReadLine().Split();
                // 입력받은 문자를 int형으로 변환해서 저장한다.
                a[i] = int.Parse(s[0]);
                b[i] = int.Parse(s[1]);
                
                // 각 숫자를 더한뒤 문자열로 변환하고 answer에 집어 넣음
                answer.AppendLine((a[i] + b[i]).ToString());
            }
            // 출력
            Console.WriteLine(answer.ToString());
        }
    }
}