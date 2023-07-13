using System;

namespace 조건문
{
    class Program
    {
        static void Main(string[] args)
        {
        	// 숫자를 입력 받아서 공백을 기준으로 잘라서 배열에 담는다.
            string[] n = Console.ReadLine().Split();
            
            // 입력된 값을 int로 변환해서 저장한다.
            int a = int.Parse(n[0]);
            int b = int.Parse(n[1]);
            
            // if 문을 사용해서 비교한다.
            if (a > b)
            {
                Console.WriteLine(">");
            }
            else if (a < b)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("==");
            }
        }
    }
}