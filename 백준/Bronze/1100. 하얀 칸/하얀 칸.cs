using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            for (int i = 0; i < 8; i++) // 8줄 입력
            {
                string line = Console.ReadLine(); // 한 줄 읽기

                for (int j = 0; j < 8; j++) // 각 줄의 문자 8개 확인
                {
                    if ((i + j) % 2 == 0 && line[j] == 'F') // 하얀 칸 + 말 있음
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count); // 결과 출력
        }
    }
}
