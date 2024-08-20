 // 입력을 받아올 준비
int[] li = new int[6];
int sum = 0;

// 6개의 정수를 입력받아 배열에 저장
for (int i = 0; i < 6; i++)
{
    li[i] = int.Parse(Console.ReadLine());
}

// 배열의 첫 4개 요소와 마지막 2개 요소 각각 정렬
Array.Sort(li, 0, 4);
Array.Sort(li, 4, 2);

// 1~3번째 요소의 합을 구함
for (int i = 1; i < 4; i++)
{
    sum += li[i];
}

// 마지막 두 요소 중 더 큰 값을 더함
sum += Math.Max(li[4], li[5]);

// 결과 출력
Console.WriteLine(sum);