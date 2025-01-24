int index = int.Parse(Console.ReadLine());

int cnt = 0;

for (int i = 0; i < index; i++)
{
    string str = Console.ReadLine();

    if (str.Contains("01") || str.Contains("OI"))
    {
        cnt++;
    }
}

Console.WriteLine(cnt);