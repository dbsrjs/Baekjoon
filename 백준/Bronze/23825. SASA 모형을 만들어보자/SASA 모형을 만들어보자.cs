string[] str = Console.ReadLine().Split();

int s = int.Parse(str[0]);
int a = int.Parse(str[1]);

int cnt = 0;

while(s >= 2 && a >= 2)
{
    cnt++;
    s -= 2;
    a -= 2;
}

Console.WriteLine(cnt);