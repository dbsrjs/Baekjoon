using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int A = int.Parse(input[1]);
        int B = int.Parse(input[2]);

        int x = 1, y = 1;

        while (N > 0)
        {
            // 1번 조건
            x += A;
            y += B;

            // 2번 조건
            if (x < y)
            {
                int temp = x;
                x = y;
                y = temp;
            }

            // 3번 조건
            if (x == y)
                y -= 1;

            N--;
        }

        Console.WriteLine($"{x} {y}");
    }
}
