using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // 입력 받기
        var input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int X = int.Parse(input[1]);

        var socks = Console.ReadLine().Split().Select(int.Parse).ToArray();

        // 가격 계산
        int minPrice = int.MaxValue;
        for (int i = 0; i < N - 1; i++)
        {
            int price = (socks[i] + socks[i + 1]) * X;
            if (price < minPrice)
            {
                minPrice = price;
            }
        }

        // 결과 출력
        Console.WriteLine(minPrice);
    }
}
