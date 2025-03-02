using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int x = int.Parse(input[0]);
        int y = int.Parse(input[1]);
        int w = int.Parse(input[2]);
        int h = int.Parse(input[3]);

        int x_min = Math.Min(x, w - x); // x축 최소거리
        int y_min = Math.Min(y, h - y); // y축 최소거리

        // x와 y축 최소거리 중 가장 작은 값 출력
        Console.WriteLine(Math.Min(x_min, y_min));
    }
}
