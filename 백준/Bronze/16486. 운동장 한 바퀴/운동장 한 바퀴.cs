using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        // 입력 받기
        int d1 = int.Parse(Console.ReadLine());
        int d2 = int.Parse(Console.ReadLine());
        
        // 상수 선언
        double pi = 3.141592;
        
        // 결과 출력
        Console.WriteLine(d1 * 2 + 2 * pi * d2);
    }
}
