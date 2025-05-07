int total = int.Parse(Console.ReadLine());

for (int i = 0; i < 9; i++)
{
    int num = int.Parse(Console.ReadLine());

    total -= num;
}

Console.WriteLine(total);