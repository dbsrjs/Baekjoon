using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine()); // 테스트 케이스 개수

            for (int i = 0; i < len; i++)
            {
                int cents = int.Parse(Console.ReadLine()); // 거스름돈 (센트 단위)

                int Q = cents / 25; // 쿼터(25센트)
                cents %= 25;

                int D = cents / 10; // 다임(10센트)
                cents %= 10;

                int N = cents / 5;  // 니켈(5센트)
                cents %= 5;

                int P = cents;      // 페니(1센트)

                Console.WriteLine($"{Q} {D} {N} {P}");
            }
        }
    }
}
