int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
int e = int.Parse(Console.ReadLine());

int cnt = 0;

if (a < 0)
    cnt += d;

while (a < 0)
{
    a += 1;
    cnt += c;
}

while (a < b)
{
    a += 1;
    cnt += e;
}

Console.WriteLine(cnt);