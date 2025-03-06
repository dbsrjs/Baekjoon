int num = int.Parse(Console.ReadLine());

for (int i = num; i >= 1; i--)
{
    for (int j = 0; j < num - i; j++)
    {
        Console.Write(" ");
    }

    for (int k = 0; k < 2 * i - 1; k++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}