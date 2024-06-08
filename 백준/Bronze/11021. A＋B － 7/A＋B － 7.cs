using System;
using System.Text;

namespace for문7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 스트링빌더 number 선언
            StringBuilder number = new StringBuilder();

            // 테스트케이스 t 입력 받음
            int t = int.Parse(Console.ReadLine());
            
            // t의 길이인 int형 배열 선언
            int[] num = new int[t];

            for (int i = 0; i < t; i++)
            {
                // 입력받아서 number에 한번에 넣어줌
                string[] s = Console.ReadLine().Split();
                num[i] = int.Parse(s[0]) + int.Parse(s[1]);
                number.AppendLine($"Case #{i+1}: " + num[i].ToString());
            }
            // 출력
            Console.WriteLine(number.ToString());
        }
    }
}