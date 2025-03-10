int N = int.Parse(Console.ReadLine());

// 위쪽 부분
for (int i = 0; i < N; i++)
{
    Console.Write(new string('*', i + 1));
    Console.Write(new string(' ', N * 2 - (i * 2) - 2));
    Console.WriteLine(new string('*', i + 1));
}

// 아래쪽 부분
for (int i = 1; i < N; i++)
{
    Console.Write(new string('*', N - i));
    Console.Write(new string(' ', i * 2));
    Console.WriteLine(new string('*', N - i));
}