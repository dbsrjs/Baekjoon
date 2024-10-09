using System;

class Program
{
    static void Main(string[] args)
    {
        // 입력을 한 줄로 받음
        string[] input = Console.ReadLine().Split();
        int bread = int.Parse(input[0]);
        int patty = int.Parse(input[1]);
        
        // 빵은 2개가 한 세트이므로 빵의 개수를 2로 나눈 값과 패티 개수 중 최소값을 찾음
        int answer = Math.Min(bread / 2, patty);
        
        // 결과 출력
        Console.WriteLine(answer);
    }
}
