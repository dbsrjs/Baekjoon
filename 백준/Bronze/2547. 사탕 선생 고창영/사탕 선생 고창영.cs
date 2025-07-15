using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());
        Console.ReadLine(); // 첫 테스트케이스 전 빈 줄 처리

        for (int t = 0; t < T; t++)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger total = 0;

            for (int i = 0; i < N; i++)
            {
                BigInteger candy = BigInteger.Parse(Console.ReadLine());
                total += candy;
            }

            Console.WriteLine(total % N == 0 ? "YES" : "NO");

            if (t < T - 1)
                Console.ReadLine(); // 테스트케이스 사이의 빈 줄 처리
        }
    }
}
