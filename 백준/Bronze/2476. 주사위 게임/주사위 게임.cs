int cases = int.Parse(Console.ReadLine());
int answer = 0;

for (int i = 0; i < cases; i++)
{
    string[] input = Console.ReadLine().Split();
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    int c = int.Parse(input[2]);

    if (a == b && b == c)
        answer = Math.Max(answer, 10000 + a * 1000);
    else if (a == b || a == c)
        answer = Math.Max(answer, 1000 + a * 100);
    else if (b == c)
        answer = Math.Max(answer, 1000 + b * 100);
    else
        answer = Math.Max(answer, 100 * Math.Max(a, Math.Max(b, c)));
}

Console.WriteLine(answer);