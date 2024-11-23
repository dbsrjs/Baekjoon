using System;
using System.IO;

class Program
{
    private const int INF = int.MaxValue;

    static void Main(string[] args)
    {
        new Program().Solution();
    }

    public void Solution()
    {
        int n = int.Parse(Console.ReadLine());
        int min = INF;

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            if (a > b) continue;
            min = Math.Min(min, b);
        }

        Console.WriteLine(min == INF ? -1 : min);
    }
}
