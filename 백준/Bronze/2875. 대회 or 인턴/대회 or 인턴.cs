 string[] input = Console.ReadLine().Split();
int N = int.Parse(input[0]);
int M = int.Parse(input[1]);
int K = int.Parse(input[2]);

int team = 0;

while (true)
{
    N -= 2;
    M -= 1;

    if (N < 0 || M < 0 || (N + M) < K)
        break;

    team++;
}

Console.WriteLine(team);