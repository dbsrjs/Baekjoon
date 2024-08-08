int cnt = int.Parse(Console.ReadLine());

for (int i = 1; i <= cnt; i++)
{
    string[] str = Console.ReadLine().Split();

    Console.WriteLine($"Case {i}: {int.Parse(str[0]) + int.Parse(str[1])}");
}