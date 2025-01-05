using System;

class Program
{
    static void Main()
    {
        // 메뉴의 개수 입력
        int n = int.Parse(Console.ReadLine());

        // 메뉴 가격을 저장하는 배열
        int[] price = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            price[i] = int.Parse(Console.ReadLine());
        }

        // 총 내야 될 가격 계산
        int sum = 0;
        n = int.Parse(Console.ReadLine()); // 새내기의 인원 수
        for (int i = 0; i < n; i++)
        {
            int index = int.Parse(Console.ReadLine()); // 먹고 싶어하는 메뉴
            sum += price[index];
        }

        // 결과 출력
        Console.WriteLine(sum);
    }
}
