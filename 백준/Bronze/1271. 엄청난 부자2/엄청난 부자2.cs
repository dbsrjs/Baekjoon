using System;
using System.Numerics; // BigInteger를 사용하기 위해 필요한 네임스페이스

class Program {
    static void Main(string[] args) {
        // 사용자로부터 문자열 입력을 받는다.
        string stringInput = Console.ReadLine();
        // 입력 받은 문자열을 공백을 기준으로 분할하여 배열로 변환한다.
        string[] arrayStrings = stringInput.Split(' ', StringSplitOptions.None);
        
        // 배열의 첫 번째 요소를 BigInteger로 변환한다.
        BigInteger N = BigInteger.Parse(arrayStrings[0]);
        // 배열의 두 번째 요소를 BigInteger로 변환한다.
        BigInteger M = BigInteger.Parse(arrayStrings[1]);

        // N을 M으로 나눈 몫을 계산한다.
        BigInteger divided = N / M;
        // N을 M으로 나눈 나머지를 계산한다.
        BigInteger remained = N % M;
        
        // 계산된 몫을 출력한다.
        Console.WriteLine(divided);
        // 계산된 나머지를 출력한다.
        Console.WriteLine(remained);
    }
}
