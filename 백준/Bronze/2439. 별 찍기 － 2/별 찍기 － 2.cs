int n = int.Parse(Console.ReadLine());

for (int i = n; i > 0; i--)
{
    for (int j = i - 1; j > 0; j--)
    {
        Console.Write(" ");
    }

    for (int k = n - i; k >= 0; k--)
        Console.Write("*");
    Console.WriteLine();
}