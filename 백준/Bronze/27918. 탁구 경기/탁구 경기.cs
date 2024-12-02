int x = 0;
int y = 0;
int cntX = 0;
int cntY = 0;

int len = int.Parse(Console.ReadLine());

for(int i = 0; i < len; i++)
{
    if (cntX == 2 || cntY == 2)
        break;

    string str = Console.ReadLine();
    if (str.Equals("D"))
    {
        cntY--;
        x++;
        cntX++;
    }

    else if (str.Equals("P"))
    {
        cntX--;
        y++;
        cntY++;
    }
}

Console.WriteLine($"{x}:{y}");