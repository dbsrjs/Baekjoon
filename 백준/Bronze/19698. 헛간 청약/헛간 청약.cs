 string[] input = Console.ReadLine().Split(' ');

// 입력값을 변수로 변환합니다.
int n = int.Parse(input[0]);
int w = int.Parse(input[1]);
int h = int.Parse(input[2]);
int l = int.Parse(input[3]);

// 가능한 상자 개수를 계산합니다.
int ans = (w / l) * (h / l);

// n과 ans 중 최소값을 출력합니다.
Console.WriteLine(Math.Min(n, ans));