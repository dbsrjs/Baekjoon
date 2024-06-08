using System;
using System.Text;

namespace for문8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 스트링빌더 number 선언
            StringBuilder number = new StringBuilder();

            // 테스트케이스 개수 입력 받음
            int t = int.Parse(Console.ReadLine());

            int[] num = new int[t];

            for (int i = 0; i < t; i++)
            {
                // 입력받아서 number에 한번에 넣어줌
                string[] ab = Console.ReadLine().Split();
                num[i] = int.Parse(ab[0]) + int.Parse(ab[1]);
                number.AppendLine($"Case #{i + 1}: {ab[0]} + {ab[1]} = " + num[i].ToString());
            }
            // 출력
            Console.WriteLine(number.ToString());
        }
    }
}