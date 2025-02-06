int T = int.Parse(Console.ReadLine());
int a, b, r;

for (int i = 0; i < T; i++)
{
    string[] str = Console.ReadLine().Split();

    a = int.Parse(str[0]);
    b = int.Parse(str[1]);

    r = 1;

    for (int j = 0; j < b; j++)
        r = (r * a) % 10;

    if (r == 0)
        r = 10;

    Console.WriteLine(r);
}