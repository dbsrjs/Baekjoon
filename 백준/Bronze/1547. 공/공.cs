int len = int.Parse(Console.ReadLine());

int pos = 1;

for (int i = 0; i < len; i++)
{
    string[] str = Console.ReadLine().Split();

    int x = int.Parse(str[0]);
    int y = int.Parse(str[1]);

    if (x == pos)
        pos = y;

    else if (y == pos)
        pos = x;
}

Console.WriteLine(pos);