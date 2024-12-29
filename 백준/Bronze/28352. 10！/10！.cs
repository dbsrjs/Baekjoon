using System;

class Program
{
    static void Main()
    {
        // 입력
        int N = int.Parse(Console.ReadLine());

        // 계산
        long res = 1;
        for (int i = 11; i <= N; i++)
        {
            res *= i;
        }

        // 출력
        Console.WriteLine(6 * res);
    }
}
