// 정수의 개수
int n = int.Parse(Console.ReadLine());

// 정수 배열
string[] numbers = Console.ReadLine().Split();

// 찾으려는 정수
string v = Console.ReadLine();

// 초기값
int result = 0;

foreach (string number in numbers)
{
    if (v.Equals(number))
        result++;
}
Console.WriteLine(result);