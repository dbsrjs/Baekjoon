using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 문자열을 입력받는다 (예: baekjoon)
        string input = Console.ReadLine();

        // 알파벳 26개를 모두 -1로 초기화 (아직 등장하지 않은 상태)
        int[] result = Enumerable.Repeat(-1, 26).ToArray();

        // 입력 문자열을 앞에서부터 순회
        for (int i = 0; i < input.Length; i++)
        {
            // 현재 문자의 알파벳 인덱스를 계산 ('a'는 0, 'b'는 1, ..., 'z'는 25)
            int idx = input[i] - 'a';

            // 해당 문자가 처음 등장했다면, 그 위치를 저장
            if (result[idx] == -1)
            {
                result[idx] = i;
            }
        }

        // 결과 배열을 공백으로 구분해서 한 줄로 출력
        Console.WriteLine(string.Join(" ", result));
    }
}
