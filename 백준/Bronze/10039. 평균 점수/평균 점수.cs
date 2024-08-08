int result = 0;

for (int i = 0; i < 5; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num < 40)
        num = 40;
    result += num;
}

Console.WriteLine(result/5);