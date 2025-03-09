using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        // 위쪽 삼각형 (역 피라미드)
        for (int i = 0; i < N; i++)
        {
            Console.Write(new string(' ', i));
            Console.WriteLine(new string('*', (2 * N - 1) - (2 * i)));
        }

        // 아래쪽 삼각형 (정방향 피라미드)
        for (int i = 0; i < N - 1; i++)
        {
            Console.Write(new string(' ', (N - 2) - i));
            Console.WriteLine(new string('*', 3 + 2 * i));
        }
    }
}
