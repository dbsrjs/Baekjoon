string[] str = Console.ReadLine().Split();
int N = int.Parse(str[0]);  //버스 개수
int X = int.Parse(str[1]);  //학교까지 걸리는 시간

int maxStart = -1;

for (int i = 0; i < N; i++)
{
    str = Console.ReadLine().Split();

    int S = int.Parse(str[0]);  //도착까지 남은 시간
    int T = int.Parse(str[1]);  //학교까지 걸리는 시간

    if (S + T <= X && maxStart < S)
        maxStart = S;
}

Console.WriteLine(maxStart);